using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Product
    {

        //static int ProductID = 0;
        /*{
            get { return ProductID; }
            set { ProductID = 0; }
        }*///added by SQL
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public Product() { }

        public Product(string name,int price)
        {
            ProductName = name;
            ProductPrice = price;
            //Console.WriteLine("In Product constructor");
        }
    }
}
