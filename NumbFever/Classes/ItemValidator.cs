using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NumbFever.Classes
{
    public static class ItemValidator
    {

        //static class for validate item details entered by the user
        public static bool ValidateItemFields(string tax,string name, string amount, string price)
        {
            if (!Validator.ValidateTextString(tax))
            {
                MessageBox.Show("Nincs kiválasztva ÁFA!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (!Validator.ValidateTextString(name))
            {
                MessageBox.Show("Helytelen megnevezés!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (!int.TryParse(amount,out int number)&&number>0)
            {
                MessageBox.Show("Helytelen mennyiség!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (!int.TryParse(price, out int numb)&&numb>0)
            {
                MessageBox.Show("Helytelen ár!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;

        }
    }
}
