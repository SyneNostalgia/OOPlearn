using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlearn
{
    internal class product
    {
        private string name;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { if(value>0) price = value; }
        }

        public product()
        {
            name = "Tester";
            price = 1000;
        }

        public product(string ProductName, double UnitPrice)
        {
            name = ProductName;
            price = UnitPrice;
        }
    }
}
