using NumbFever.Classes;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            loadDatas();
        }
        //validate the items, and save them to their files
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] records = { NameBox.Text, AddressBox.Text, TaxNumberBox.Text, AccountNumberBox.Text };
            if(!Validator.ValidateTextArray(records))
                {
                    MessageBox.Show("Hibás adatok!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            InfoHandler.ownCompany.Name = NameBox.Text;
            InfoHandler.ownCompany.Address = AddressBox.Text;
            InfoHandler.ownCompany.TaxNumber = TaxNumberBox.Text;
            InfoHandler.ownCompany.AccountNumber = AccountNumberBox.Text;
            if (Validator.ValidateTaxRate(TaxToAddBox.Text) && !InfoHandler.taxRate.TaxRates.Contains(TaxToAddBox.Text))
            {
                InfoHandler.taxRate.TaxRates.Add(TaxToAddBox.Text);
            }
            if (Validator.ValidateTaxRate(TaxToDelete.Text))
                InfoHandler.taxRate.TaxRates.Remove(TaxToDelete.Text);

            InfoHandler.SaveDatas();
            loadDatas();
            MessageBox.Show("Sikeres mentés", "Mentve", MessageBoxButton.OK);
        }

        //Load the user's company datas and the current tax rates to their boxes
        private void loadDatas()
        {
            NameBox.Text = InfoHandler.ownCompany.Name;
            AddressBox.Text = InfoHandler.ownCompany.Address;
            TaxNumberBox.Text = InfoHandler.ownCompany.TaxNumber;
            AccountNumberBox.Text = InfoHandler.ownCompany.AccountNumber;
            RecentTax.ItemsSource = null;
            RecentTax.ItemsSource = InfoHandler.taxRate.TaxRates;
            TaxToDelete.ItemsSource = null;
            TaxToDelete.ItemsSource = InfoHandler.taxRate.TaxRates;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
