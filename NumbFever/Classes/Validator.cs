using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbFever.Classes
{
    public static class Validator
    {
        //validator for strings
        public static bool ValidateTextString(string text)
        {
            bool result = true;
            if (string.IsNullOrEmpty(text))
                result = false;
            if (string.IsNullOrWhiteSpace(text))
                result = false;

            return result;
        }

        public static bool ValidateTextArray(string[] textArr)
        {
            bool result = true;
            foreach (var item in textArr)
            {
                if (string.IsNullOrEmpty(item))
                    return false;
                if (string.IsNullOrWhiteSpace(item))
                    return  false;
            }

            return result;
        }

        public static bool ValidateTaxRate(string taxRate)
        {
            return int.TryParse(taxRate, out int numb);

        }
    }
}
