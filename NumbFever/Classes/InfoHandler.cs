using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbFever.Classes
{
    public static class InfoHandler
    {
        //this class contains the datas of the own company and the taxrate as a static class
        public static OwnCompany ownCompany;
        public static TaxRate taxRate;
        private static string currentDir = Directory.GetCurrentDirectory();
        static InfoHandler()
        {
            ownCompany = new OwnCompany();
            taxRate = new TaxRate();
        }
        //Read the datas of the user's  company from OwnCompany.txt file.
        private static void readOwnCompany()
        {
            string[] properties = File.ReadAllLines(currentDir + "\\Settings\\OwnCompany.txt");
            ownCompany.Name = properties[0];
            ownCompany.Address = properties[1];
            ownCompany.TaxNumber = properties[2];
            ownCompany.AccountNumber = properties[3];

        }

        //Read the recent tax rates from Tax.txt
        private static void readTax()
        {
            string[] properties = File.ReadAllLines(currentDir + "\\Settings\\Tax.txt");
            taxRate.TaxRates = properties.ToList();
        }

        //Write the new datas of the user's company into the OwnCompany.txt file
        private static void SaveOwnCompanyDatas()
        {
            string[] datas = {ownCompany.Name,ownCompany.Address, ownCompany.TaxNumber, ownCompany.AccountNumber };
            File.WriteAllLines(currentDir + "\\Settings\\OwnCompany.txt", datas);
        }

        //Write the new taxrates to the Tax.txt file
        private static void SaveTaxRates()
        {
            string[] datas = taxRate.TaxRates.ToArray();
            File.WriteAllLines(currentDir + "\\Settings\\Tax.txt", datas);
        }
        //Invokes the methods for reading both the taxrates, and the datas of the user's company.
        public static void readDatas()
        {
            readOwnCompany();
            readTax();
        }

        //Invokes the methods for saving both the taxrates, and the datas of the user's company.
        public static void SaveDatas()
        {
            SaveOwnCompanyDatas();
            SaveTaxRates();
        }
    }
}
