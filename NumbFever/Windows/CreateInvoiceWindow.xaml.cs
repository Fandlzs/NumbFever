using NumbFever.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NumbFever.Windows
{
    /// <summary>
    /// Interaction logic for CreateInvoiceWindow.xaml
    /// </summary>
    public partial class CreateInvoiceWindow : Window
    {
        public CreateInvoiceWindow()
        {
            InitializeComponent();
            PartnerNames.ItemsSource = PartnerHandler.partners;
            TaxList.ItemsSource = InfoHandler.taxRate.TaxRates;
            CurrencyList.ItemsSource = new string[]{"HUF","USD","EUR" };
            MethodOfPaymentList.ItemsSource = new string[] { "Átutalás", "Készpénz" };
        }

        private void PartnerNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PartnerAddressBox.Text = (PartnerNames.SelectedItem as Partner).Address;
            PartnerTaxNumberBox.Text = (PartnerNames.SelectedItem as Partner).Taxnumber;
            PartnerAccountNumberBox.Text = (PartnerNames.SelectedItem as Partner).BankAccountNumber;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NewItemBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!CheckCurrencyList())
            {
                return;
            }
            if(TaxList.SelectedItem!=null&&!ItemValidator.ValidateItemFields(TaxList.SelectedItem.ToString(),ItemNameBox.Text,ItemAmountBox.Text,ItemPriceBox.Text))
            {
                return;
            }
            Item item = new Item(ItemNameBox.Text, CurrencyList.SelectedItem.ToString(), double.Parse(ItemPriceBox.Text), double.Parse(ItemAmountBox.Text), double.Parse(TaxList.SelectedItem.ToString()));
            ItemHandler.AddItem(item);
            ItemsGrid.ItemsSource = null;
            ItemsGrid.ItemsSource = ItemHandler.GetItems();
            RenameDataGridHeaders();
        }

        private bool CheckCurrencyList()
        {
            if (CurrencyList.SelectedItem == null)
            {
                MessageBox.Show("Nincs pénznem kiválasztva!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
            {
                CurrencyList.IsHitTestVisible = false;
                CurrencyList.Focusable = false;
                return true;
            }
        }
        private void RenameDataGridHeaders()
        {
            ItemsGrid.Columns[0].Header = "Megnevezés                                     ";
            ItemsGrid.Columns[1].Header = "Pénznem                        ";
            ItemsGrid.Columns[2].Header = "Egységár                        ";
            ItemsGrid.Columns[3].Header = "Mennyiség                        ";
            ItemsGrid.Columns[4].Header = "Nettó ár                       ";
            ItemsGrid.Columns[5].Header = "ÁFA                     ";
            ItemsGrid.Columns[6].Header = "ÁFA összege             ";
            ItemsGrid.Columns[7].Header = "Bruttó ár               ";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Item item = ItemsGrid.SelectedItem as Item;
            ItemHandler.RemoveItem(item);
            ItemsGrid.ItemsSource = null;
            ItemsGrid.ItemsSource = ItemHandler.GetItems();
            RenameDataGridHeaders();
        }

        //Create an invoice as a txt file with the name of the company and with an unique number.
        private void SaveInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            if(PartnerNames.SelectedItem==null|| DateOfDeliveryBox.SelectedDate==null || TermOfPaymentBox.SelectedDate == null || CurrencyList.SelectedItem==null || MethodOfPaymentList.SelectedItem==null || ItemHandler.GetItems().Count==0)
            {
                MessageBox.Show("Hiányzó adatok!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            long n = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));
            Partner selectedPartner = PartnerNames.SelectedItem as Partner;
            string date = n.ToString();
            string path = $"{PartnerNames.SelectedItem.ToString()}\\{PartnerNames.SelectedItem.ToString().Replace(".", "")}{date}";
            using (FileStream file = File.Open(path+".txt", FileMode.Create))
            {
                List<string> datas = new List<string>();
                
                datas.Add(string.Format("E-szamla{0,85}{1}", "", InfoHandler.ownCompany.Name));
                datas.Add(string.Format("{0,60} {1,40}", "", InfoHandler.ownCompany.Address));
                datas.Add(string.Format("{0,60} {1,-15}{2,-30}", "", "Adoszam:", InfoHandler.ownCompany.TaxNumber));
                datas.Add(string.Format("{0,60} {1,-15}{2,-30}", "", "Bankszamlaszam:", InfoHandler.ownCompany.AccountNumber));
                datas.Add(drawLine());
                datas.Add("Vevo adatai: ");
                datas.Add("Vevo neve:" + selectedPartner.Name);
                datas.Add("Vevo címe:" + selectedPartner.Address);
                datas.Add("Szamlaszam: " + selectedPartner.BankAccountNumber);
                datas.Add("Szamla kelte: " + DateTime.Now.ToString("yyyy.MM.dd"));
                datas.Add("Teljesites idopontja: " + ((DateTime)DateOfDeliveryBox.SelectedDate).ToString("yyyy.MM.dd"));
                datas.Add("Fizetesi hatarido: " + ((DateTime)TermOfPaymentBox.SelectedDate).ToString("yyyy.MM.dd"));
                datas.Add("Szamla szama: " + n);
                datas.Add(drawLine());
                string header = string.Format("{0}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}{7,15}", "Megnevezes", "Penznem" , "Egysegar", "Mennyiseg", "Netto ar", "AFA%","AFA", "Brutto ar");
                datas.Add(header);
                double finalPrice = 0;
                string currency = ItemHandler.GetItems()[0].Currency;
                foreach (var item in ItemHandler.GetItems())
                {
                    string datasUnderHeader = string.Format("{0}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}{7,15}",item.Name, item.Currency, item.Price, item.Amount, item.NetPrice, item.Tax, item.TaxAmount, item.BruttoPrice);
                    datas.Add(datasUnderHeader);
                    finalPrice += item.BruttoPrice;
                }
                datas.Add(drawLine());


                datas.Add(string.Format("Fizetendo:{0,60} {1}.", finalPrice,currency));
                
                string[] dataArray = datas.ToArray();
                for (int i = 0; i < dataArray.Length;i++)
                {
                    dataArray[i] = CharacterReplacer.replaceAccentuatedLetters(dataArray[i]);
                }
                using (StreamWriter writer = new StreamWriter(file))
                {
                    int counter = 0;
                    foreach (var item in dataArray)
                    {

                        writer.WriteLine(item);
                        writer.WriteLine();
                        writer.WriteLine();
                        if (counter == 0 || counter == 3)
                        {
                            writer.WriteLine();
                            writer.WriteLine();
                            writer.WriteLine();
                        }
                        counter++;
                    }
                }
                PdfConverter.GeneratePdf(path);
            }
            MessageBox.Show("Sikeres mentés!", "Mentve", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        private string drawLine()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 110; i++)
            {
                sb.Append("_");
            }
            return sb.ToString();
        }
    }
}
