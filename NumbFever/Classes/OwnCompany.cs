using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbFever.Classes
{
    public class OwnCompany
    {
        //this class contains the data of the user's company
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string taxNumber;

        public string TaxNumber
        {
            get { return taxNumber; }
            set { taxNumber = value; }
        }

        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public OwnCompany(string companyName, string companyAddress, string companyTaxNumber, string companyAccountNumber)
        {
            this.name = companyAddress;
            this.address = companyAddress;
            this.taxNumber = companyTaxNumber;
            this.accountNumber = companyAccountNumber;
        }

        public OwnCompany()
        {

        }

    }
}
