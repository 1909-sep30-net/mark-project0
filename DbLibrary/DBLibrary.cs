// Entity Framework Core
// database-first approach steps...
/*
 * 1. have a data access library project separate from the startup application project.
 *    (with a project reference from the latter to the former).
 * 2. install Microsoft.EntityFrameworkCore.Design and Microsoft.EntityFrameworkCore.SqlServer
 *    to both projects.
 * 3. using Git Bash / terminal, from the data access project folder run..without braces.
 * [dotnet ef dbcontext scaffold "Server=tcp:mooremark.database.windows.net,1433;Initial Catalog=Project0;Persist Security Info=False;User ID=mark.c.moore@hotmail.com@mooremark.database.windows.net;Password=cU5tod33qUal;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer --startup-project ../mark-project0 --force --output-dir Entities]

 *    https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet#dotnet-ef-dbcontext-scaffold
 *    (if you don't have dotnet ef installed, run: "dotnet tool install --global dotnet-ef")
 *    (this will fail if your projects do not compile)
 * 4. delete the DbContext.OnConfiguring method from the scaffolded code.
 *    (so that the connection string is not put on the public internet)
 * 5. any time you change the structure of the tables (DDL), go to step 3.
 */


using System;
using System.Collections.Generic;
using ClassLibrary1;
using DbLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBLibrary
{
    public class DbLibrary
    {
        //this library is for manipulating the DB.. insert, delete, search, etc
        //public static List<Customer>  customers   = new List<Customer>();
        //public static List<Location>  locations   = new List<Location>();
        //public static List<Product>   products    = new List<Product>();
        //public static List<Order>     orders      = new List<Order>();

        /**************************************
         * PRODUCT FUNCTIONS BELOW
         * ************************************/
        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static int AddProduct(Products product)
        //{
        //    using (var db = new Project0Context())
        //    {
        //        Console.WriteLine("Inserting a new product");
        //        db.Add(product);
        //        //db.Add(new Products
        //        //{
        //        //    ProductName = "mango",
        //        //    ProductPrice = 1234
        //        //});
        //        db.SaveChanges();
        //        //products.Add(product);
        //        return 1;
        //    }
        //}

        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static Products ReadProduct(Products product)
        //{
        //    //find the product in the array
        //    using (var db = new Project0Context())
        //    {
        //        Console.WriteLine("Reading a product");
        //        var prod = db.Products.Find(2);
        //        return prod;
        //    }
        //}

        ///<summary>
        ///returns a list of all the Products
        ///</summary>
        public static DbSet<Products> ReadAllProducts(Project0Context context)
        {
            //find all the products in the array
            Console.WriteLine("Reading a product");
            return context.Products;
        }

        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static List<Product> UpdateProduct(Project0Context context, Product product)
        //{
        //    //find then update the product
        //    return products;
        //}

        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static List<Product> DeleteProduct(List<Product> products, Product product)
        //{
        //    return products;
        //}


        ///<summary>
        //////This option not required at this time
        ///</summary>
        //public static Product SearchProducts(Product product)
        //{
        //    return product;
        //}

        /**************************************
         * LOCATION FUNCTIONS BELOW
         * *************************************/

        ///<summary>
        //////This option not required at this time
        ///</summary>
        //public static int AddLocation(Location location)
        //{
        //    using (var db = new Project0Context())
        //    {
        //        Console.WriteLine("Inserting a new product");
        //        db.Add(location);
        //        //db.Add(new Products
        //        //{
        //        //    ProductName = "apple",
        //        //    ProductPrice = 1234
        //        //});
        //        db.SaveChanges();
        //        //products.Add(product);
        //        return 1;
        //        //locations.Add(location);
        //        //return locations;
        //    }
        //}

        ///<summary>
        ///</summary>
        public static DbSet<Locations> ReadAllLocations(Project0Context context)
        {
            //make a list of locations
            return context.Locations;
        }

        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static Location ReadOneLocation(Location location)//this might be accomplished with SearchLocations() below
        //{
        //    return location;
        //}

        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static void UpdateLocation(Location location)
        //{

        //}

        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static void DeleteLocation(Location location)
        //{

        //}


        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static Location SearchLocations(Location location)
        //{
        //    return location;
        //}


        /**************************************
         * CUSTOMER FUNCTIONS BELOW
         * *************************************/

        public static void AddCustomer(Customer customer)
        {
/*            Console.WriteLine(cust.CustomerFirstName);
            Console.WriteLine(cust.CustomerLastName);
            Console.WriteLine(cust.CustomerStreet);
            Console.WriteLine(cust.CustomerCity);*/
            //Console.WriteLine(cust.CustomerZipCode);
            //DbLibrary db = new DbLibrary();
            //Customer cust1 = cust;
            //customers.Add(customer);
            //return customers;

        }


        ///<summary>
        ///This method takes the verified customer info from main and inserts it into the DB
        ///</summary>
        public static Customer ReadCustomer(Project0Context context, Customer customer)
        {
            return customer;
        }

        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static List<Customer> ReadAllCustomers()
        //{
        //    return customers;
        //}

        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static List<Customer> UpdateCustomer(List<Customer> Customers, Customer customer)
        //{
        //    return Customers;
        //}

        ///<summary>
        ///This option not required at this time 
        ///</summary>
        //public static List<Customer> DeleteCustomer(List<Customer> Customers, Customer customer)
        //{
        //    //Customers.Find(customer);//find out how to find and delete from a list.
        //    return Customers;
        //}


        /**************************************
         * ORDER FUNCTIONS BELOW
         * *************************************/

        ///<summary>
        ///This option will take a complete order object and insert it into the DB
        ///</summary>
        public static void AddOrder(Project0Context context, Order order)
        {
            //return orders;
        }

        ///<summary>
        ///This option will take the details of an order inputted by the user and searches for a matching order. 
        ///Then returns the order to main for display
        ///</summary>
        public static Order ReadOrder(Project0Context context, Order order)
        {
            return order;
        }

        ///<summary>
        ///</summary>
        public static DbSet<Orders> ReadAllOrders(Project0Context context)
        {
            return context.Orders;
        }

        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static List<Order> UpdateOrder(List<Order> orders, Order order)
        //{
        //    return orders;
        //}

        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static List<Order> DeleteOrder(List<Order> orders, Order order)
        //{
        //    return orders;
        //}

    }
}
