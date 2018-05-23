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
    /// Interaction logic for CreatePartnerWindow.xaml
    /// </summary>
    public partial class CreatePartnerWindow : Window
    {
        public CreatePartnerWindow()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Partner partner = new Partner(PartnerNameBox.Text, AddressBox.Text, PartnerTaxNumberBox.Text, PartnerAccountNumberBox.Text, PartnerContactNameBox.Text, PartnerContactPositionBox.Text, PartnerContactPhoneBox.Text, PartnerOtherBox.Text);
            bool valid = PartnerValidator.ValidatePartner(partner);
            if (valid)
            {
                if (!PartnerHandler.SearchForPartner(partner))
                {
                    PartnerHandler.CreateDirectoryForPartner(partner);
                    PartnerHandler.SavePartner(partner,false);
                    MessageBox.Show("Sikeres mentés", "Kész", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Már létezik ilyen névvel partnercég", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
