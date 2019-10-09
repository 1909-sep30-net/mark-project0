using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace DBLibrary
{
    public class DbLibrary
    {
        //this library is for manipulating the DB.. insert, delete, search, etc
        public static List<Customer>  customers   = new List<Customer>();
        public static List<Location>  locations   = new List<Location>();
        public static List<Product>   products    = new List<Product>();
        public static List<Order>     orders      = new List<Order>();

        /**************************************
         * PRODUCT FUNCTIONS BELOW
         * ************************************/

        public static int AddProduct(Product product)
        {
            products.Add(product);
            return 1;
        }

        ///<summary>
        ///</summary>
        public static Product ReadProduct(Product product)
        {
            //find the product in the array
            return product;
        }

        ///<summary>
        ///</summary>
        public static List<Product> ReadAllProducts()
        {
            //find the product in the array
            return products;
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
        public static Product SearchProcucts(Product product)
        {
            return product;
        }

        /**************************************
         * LOCATION FUNCTIONS BELOW
         * *************************************/

        public static List<Location> AddLocation(Location location)
        {
            locations.Add(location);
            return locations;
        }

        ///<summary>
        ///</summary>
        public static List<Location> ReadAllLocations()
        {
            //make a list of locations
            return locations;
        }

        ///<summary>
        ///</summary>
        public static Location ReadOneLocation(Location location)//this might be accomplished with SearchLocations() below
        {
            return location;
        }

        ///<summary>
        ///</summary>
        public static void UpdateLocation(Location location)
        {

        }

        ///<summary>
        ///</summary>
        public static void DeleteLocation(Location location)
        {
            
        }


        ///<summary>
        ///</summary>
        public static Location SearchLocations(Location location)
        {
            return location;
        }


        /**************************************
         * CUSTOMER FUNCTIONS BELOW
         * *************************************/

        public static List<Customer> AddCustomer(Customer customer)
        {
/*            Console.WriteLine(cust.CustomerFirstName);
            Console.WriteLine(cust.CustomerLastName);
            Console.WriteLine(cust.CustomerStreet);
            Console.WriteLine(cust.CustomerCity);*/
            //Console.WriteLine(cust.CustomerZipCode);
            //DbLibrary db = new DbLibrary();
            //Customer cust1 = cust;
            customers.Add(customer);
            return customers;

        }


        ///<summary>
        ///</summary>
        public static Customer ReadCustomer(Customer customer)
        {
            return customer;
        }

        ///<summary>
        ///</summary>
        public static List<Customer> ReadAllCustomers()
        {
            return customers;
        }

        ///<summary>
        ///</summary>
        public static List<Customer> UpdateCustomer(List<Customer> Customers, Customer customer)
        {
            return Customers;
        }

        ///<summary>
        ///</summary>
        public static List<Customer> DeleteCustomer(List<Customer> Customers, Customer customer)
        {
            //Customers.Find(customer);//find out how to find and delete from a list.
            return Customers;
        }


        /**************************************
         * ORDER FUNCTIONS BELOW
         * *************************************/

        public static List<Order> AddOrder(List<Order> orders, Order order)
        {
            return orders;
        }

        ///<summary>
        ///</summary>
        public static List<Order> ReadOrder(List<Order> orders, Order order)
        {
            return orders;
        }

        ///<summary>
        ///</summary>
        public static List<Order> ReadAllOrders(List<Order> orders, Order order)
        {
            return orders;
        }

        ///<summary>
        ///</summary>
        public static List<Order> UpdateOrder(List<Order> orders, Order order)
        {
            return orders;
        }

        ///<summary>
        ///</summary>
        public static List<Order> DeleteOrder(List<Order> orders, Order order)
        {
            return orders;
        }

    }
}
