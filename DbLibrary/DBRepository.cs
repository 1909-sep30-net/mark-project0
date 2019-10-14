//TEST COMMIT
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
using System.Linq;
using ClassLibrary1;
using DbLibrary.Entities;
using Microsoft.EntityFrameworkCore;
//using DbLibrary.Mapper;

namespace DBLibrary
{
    public class DBRepository
    {
        /**************************************
        * INVENTORY FUNCTIONS BELOW
        * ************************************/

        private static Project0Context _dbContext;

        public static void ReadLocationInventory(Project0Context context, string locationName)
        {
            //find all the products for that location
            Console.WriteLine("Reading the inventory");


            //var result = context.Inventory
               // .Where(i => i.ProductName == locationName).ToList();

            /*            foreach (var item in result)
                        {
                            Console.WriteLine($"{item.ProductId}\t{item.ProductName} = {item.ProductPrice}. {item.ProductQuantity} in stock.\n");
                        }*/
           // return result;
        }


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
            return context.Products;
/*            //find all the products in the array
            Console.WriteLine("Reading all products");

            List<Product> prods = new List<Product>();

            foreach (var p in context.Products)
            {
                //Product prod = new Product();
                //prod = Mapper.MapProduct(p);
                prods.Add(Mapper.MapProduct(p));
            }*/

            
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
        public static DbSet<Locations> ReadAllLocations(Project0Context db)
        {
            //make a list of locations
            //IEnumerable<Location> locationsList = new List<Location>();
/*            foreach (var l in db.Locations)
            {
                Console.WriteLine($"ID =>{l.LocationId}");
                //Location location = new Location();
                //prod = Mapper.MapProduct(p);
                Location m = new Location();
                m = Mapper.MapLocation(l);
                Console.WriteLine($"CITY =>{m.LocationCity}");

                db.Locations.Add(l);
            }*/
            //Console.WriteLine(locationsList.Count());
            return db.Locations;
        }

        ///<summary>
        ///This option not required at this time
        ///</summary>
        //public static bool ReadOneLocation(Project0Context context, int location)//this might be accomplished with SearchLocations() below
        //{
        //    if()
        //    return true;
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

        public static void AddCustomer(Project0Context context, Customer customer)
        {

            //needs to be mapped first!!!
            //Customer
            context.Add(customer);
            context.SaveChanges();
        }


        ///<summary>
        ///This method takes the verified customer info from main and inserts it into the DB
        ///</summary>
        public static void ReadCustomer(Project0Context context, Customer customer)
        {
            //Customer = 
            //var result = _db.Customers.Where(c => c.CustomerFirstName == customer.CustomerFirstName && c.CustomerLastName == customer.CustomerLastName);
            //need to typedef the result
            //Customers test1 = result.Cast<Customers>();
            //return result.FirstOrDefault();
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
        public static void AddOrder(Project0Context context, Orders order)
        {
            //return orders;
        }

        ///<summary>
        ///This option will take the details of an order inputted by the user and searches for a matching order. 
        ///Then returns the order to main for display
        ///</summary>
        public static Orders ReadOrder(Project0Context context, Orders order)
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
