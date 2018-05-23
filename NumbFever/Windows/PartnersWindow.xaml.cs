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
    /// Interaction logic for PartnersWindow.xaml
    /// </summary>
    public partial class PartnersWindow : Window
    {
        public PartnersWindow()
        {
            InitializeComponent();
            PartnerHandler.RefreshPartners();
            PartnersList.ItemsSource = null;
            PartnersList.ItemsSource = PartnerHandler.partners;
        }

        private void NewPartnerBtn_Click(object sender, RoutedEventArgs e)
        {
            CreatePartnerWindow win = new CreatePartnerWindow();
            win.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            PartnerHandler.RefreshPartners();
            PartnersList.ItemsSource = null;
            PartnersList.ItemsSource = PartnerHandler.partners;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EditPartnerBtn_Click(object sender, RoutedEventArgs e)
        {
            if(PartnersList.SelectedItem == null)
            {
                MessageBox.Show("Nincs kiválasztott partner!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string name = (PartnersList.SelectedItem as Partner).Name;
            Partner selectedPartner = PartnerHandler.partners.Where(x=>x.Name==name).First(); ;
            EditPartnerWindow win = new EditPartnerWindow(selectedPartner);
            win.ShowDialog();
            PartnerHandler.RefreshPartners();
            PartnersList.ItemsSource = null;
            PartnersList.ItemsSource = PartnerHandler.partners;

        }
    }
}
