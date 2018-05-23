using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbFever.Classes
{
    public class Item
    {
        //class for store the datas of an invoice's item
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string currency;

        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }


        public double NetPrice { get { return amount * price; } }

        private double tax;

        public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        

        public double TaxAmount { get { return NetPrice/100*Tax; } }

        public double BruttoPrice { get {return NetPrice + TaxAmount; } }

        //Constructor
        public Item(string name,string currency, double price,double amount,double tax)
        {
            Name = name;
            Currency = currency;
            Price = price;
            Amount = amount;
            Tax = tax;
        }
    }
}
