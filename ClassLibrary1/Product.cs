using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Product
    {

        static int ProductID = 0;    
        /*{
            get { return ProductID; }
            set { ProductID = 0; }
        }*///added by SQL
        public int      prodID;
        public string   ProductName     { get; set; }
        public int      ProductQuantity { get; set; }
        public int      ProductPrice    { get; set; }
        //public int something? { get; set; }
    
        public Product(string name, int quantity, int price)
        {
            ProductID++;
            prodID = ProductID;
            ProductName = name;
            ProductQuantity = quantity;
            ProductPrice = price;
            //Console.WriteLine("In Product constructor");
        }

        /*
        public static List<Product> AddProduct(List<Product> products, Product product)
        {
            products.Add(product);
            return products;
        }

        ///<summary>
        ///</summary>
        public static Product ReadProduct(List<Product> products, Product product)
        {
            //find the product in the array
            return product;
        }

        ///<summary>
        ///</summary>
        public static List<Product> UpdateProduct(List<Product> products, Product product)
        {
            //find then update the product
            return products;
        }

        ///<summary>
        ///</summary>
        public static List<Product> DeleteProduct(List<Product> products, Product product)
        {
            return products;
        }

        ///<summary>
        ///</summary>
        public static Product SearchProcucts(List<Product> products, Product product)
        {
            return product;
        }
*/
    }

}
