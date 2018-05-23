using NumbFever.Classes;
using NumbFever.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumbFever
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ComponentsChecker checker = new ComponentsChecker();
        string path = Directory.GetCurrentDirectory();

        public MainWindow()
        {
            InitializeComponent();
            checker.CheckComponents(path);
            InfoHandler.readDatas();
            PartnerHandler.RefreshPartners();
            
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow win = new SettingsWindow();
            win.ShowDialog();
        }

        private void PartnersBtn_Click(object sender, RoutedEventArgs e)
        {
            PartnersWindow win = new PartnersWindow();
            win.ShowDialog();
        }

        private void NewInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            ItemHandler.ClearItemList();
            CreateInvoiceWindow win = new CreateInvoiceWindow();
            win.ShowDialog();
        }

        private void InvoiceListBtn_Click(object sender, RoutedEventArgs e)
        {
            InvoiceSearchWindow win = new InvoiceSearchWindow();
            win.ShowDialog();
        }
    }
}
