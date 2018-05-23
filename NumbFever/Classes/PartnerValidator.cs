using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NumbFever.Classes
{
    public static class PartnerValidator
    {

        //a very simple validator for the partner object
        public static bool ValidatePartner(Partner partner)
        {

            if (partner.Name.Length < 3)
            {
                MessageBox.Show("Hibás név!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else if (partner.Taxnumber.Length < 5)
            {

                MessageBox.Show("Hibás adószám!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else if (partner.BankAccountNumber.Length < 10)
            {

                MessageBox.Show("Hibás bankszámlaszám!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            else if (partner.ContactName.Length<8)
            {
                MessageBox.Show("Hibás a kontaktszemély neve!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else if (partner.ContactPosition == "")
            {
                MessageBox.Show("Hibás a kontaktszemély pozíciója!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else if (partner.ContactPhoneNumber.Length<7)
            {
                MessageBox.Show("Hibás a kontaktszemély telefonszáma!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else if (partner.Address.Length<10)
            {
                MessageBox.Show("A cím mező nem lehet üres!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            else if (partner.Other == "")
            {
                MessageBox.Show("Az egyéb mező nem lehet üres!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;

        }
    }
}
