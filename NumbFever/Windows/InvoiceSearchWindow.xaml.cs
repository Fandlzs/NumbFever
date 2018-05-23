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
    /// Interaction logic for InvoiceSearchWindow.xaml
    /// </summary>
    public partial class InvoiceSearchWindow : Window
    {
        private List<string> partnerNames;
        private List<string> loadedInvoices;

        public InvoiceSearchWindow()
        {

            InitializeComponent();
            partnerNames = new List<string>();
            loadedInvoices = new List<string>();

            foreach (var item in PartnerHandler.partners)
            {
                partnerNames.Add(item.Name);
            }
            PartnerList.ItemsSource = partnerNames.ToArray();
        }

        private void PartnerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            loadedInvoices = Directory.GetFiles($"{PartnerList.SelectedItem.ToString()}\\").ToList(); ;
            string[] filteredInvoices = new string[(loadedInvoices.Count() - 1)];
            int n = 0;
            for (int i = 0; i < loadedInvoices.Count; i++)
            {
                if (loadedInvoices[i] == $"{PartnerList.SelectedItem.ToString()}\\{PartnerList.SelectedItem.ToString().Replace(".", "")}.txt")
                {

                    continue;

                }
                else
                {
                    string shortInvoiceName = loadedInvoices[i].Remove(0, PartnerList.SelectedItem.ToString().Length + 1);
                    filteredInvoices[n] = shortInvoiceName;
                    n++;
                }
            }
            InvoiceList.ItemsSource = null;
            InvoiceList.ItemsSource = filteredInvoices;
        }

        private void InvoiceList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (InvoiceList.SelectedItem == null)
                return;
            InvoiceBox.Text = null;
            string selected = InvoiceList.SelectedItem.ToString();
            string path = "";
            foreach (string item in loadedInvoices)
            {
                if (item.Contains(selected))
                {
                    path = item;
                }
            }

            string[] readedInvoice = File.ReadAllLines(path);
            StringBuilder sb = new StringBuilder();
            foreach (string item in readedInvoice)
            {
                sb.AppendLine(item);


            }
            InvoiceBox.Text = sb.ToString(); ;
        }
    }
}
