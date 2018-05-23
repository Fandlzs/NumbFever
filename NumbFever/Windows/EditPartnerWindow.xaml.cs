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
    /// Interaction logic for EditPartnerWindow.xaml
    /// </summary>
    public partial class EditPartnerWindow : Window
    {
        Partner selectedPartner;

        public EditPartnerWindow(Partner partner)
        {
            InitializeComponent();
            selectedPartner = partner;
            PartnerNameBox.Text = selectedPartner.Name;
            AddressBox.Text = selectedPartner.Address;
            PartnerTaxNumberBox.Text = selectedPartner.Taxnumber;
            PartnerAccountNumberBox.Text = selectedPartner.BankAccountNumber;
            PartnerContactNameBox.Text = selectedPartner.ContactName;
            PartnerContactPhoneBox.Text = selectedPartner.ContactPhoneNumber;
            PartnerContactPositionBox.Text = selectedPartner.ContactPosition;
            PartnerOtherBox.Text = selectedPartner.Other;
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            selectedPartner.Address = AddressBox.Text;
            selectedPartner.Taxnumber = PartnerTaxNumberBox.Text;
            selectedPartner.BankAccountNumber = PartnerAccountNumberBox.Text;
            selectedPartner.ContactName = PartnerContactNameBox.Text;
            selectedPartner.ContactPhoneNumber = PartnerContactPhoneBox.Text;
            selectedPartner.ContactPosition = PartnerContactPositionBox.Text;
            selectedPartner.Other = PartnerOtherBox.Text;
            if(!PartnerValidator.ValidatePartner(selectedPartner))
            {
                return;
            }
            PartnerHandler.SavePartner(selectedPartner, true);
            MessageBox.Show("Sikeres mentés!", "Mentve", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}
