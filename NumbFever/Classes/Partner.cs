using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbFever.Classes
{
    public class Partner
    {
        //Class for store a partner datas

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

        private string taxnumber;

        public string Taxnumber
        {
            get { return taxnumber; }
            set { taxnumber = value; }
        }

        private string bankAccountNumber;

        public string BankAccountNumber
        {
            get { return bankAccountNumber; }
            set { bankAccountNumber = value; }
        }

        private string contactName;

        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }

        private string contactPhoneNumber;

        public string ContactPhoneNumber
        {
            get { return contactPhoneNumber; }
            set { contactPhoneNumber = value; }
        }

        private string contactPosition;

        public string ContactPosition
        {
            get { return contactPosition; }
            set { contactPosition = value; }
        }

        private string other;

        public string Other
        {
            get { return other; }
            set { other = value; }
        }


        public Partner(string name, string address, string taxNumber, string accountNumber, string contactName, string contactPosition, string contactPhoneNumber, string other)
        {
            Name = name;
            Address = address;
            Taxnumber = taxNumber;
            BankAccountNumber = accountNumber;
            ContactName = contactName;
            ContactPosition = contactPosition;
            ContactPhoneNumber = contactPhoneNumber;
            Other = other;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
