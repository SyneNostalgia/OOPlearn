using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlearn
{
    internal class Product2:product
    {
        //private int unitinstock;
        //public int UnitInStock
        //{
        //    get { return unitinstock; }
        //    set { unitinstock = value; }
        //}
        public int UnitInStock { get; set; }
        public string Unit { get; set; }

        public Product2()
        {
            Name = "ขี้";
            Price = 7;
            UnitInStock = 245681;
            Unit = "ก้อน";
        }
    }
}
