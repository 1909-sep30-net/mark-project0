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


using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary1;
using DbLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBLibrary
{
    public class DBRepository
    {
        private static readonly NLog.ILogger s_logger = LogManager.GetCurrentClassLogger();


        /**************************************
        * INVENTORY FUNCTIONS BELOW
        * ************************************/
        /// <summary>
        /// this method takes the context and location name and returns a List of Inventory objects in 
        /// that locations inventory.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="locationName"></param>
        /// <returns>List<Products> </returns>
        public static List<Inventory> ReadLocationInventory(Project0Context context, string locationName)
        {
            //find all the products for that location
            //Console.WriteLine("Reading the inventory");

            var result = context.Inventory
                .Where(i => i.LocationName == locationName).ToList();

            /*          var result = context.Products
                      .Join(context.Inventory
                      .Where(i => i.LocationName == locationName),
                            m => m.ProductId,
                            p => p.ProductId,
                            (m, p) => m)
                              .ToList();*/
            /*            var result = (from d in context.Products
                                         join f in context.Inventory
                                         on d.ProductId equals f.ProductId
                                         where f.LocationName == locationName
                                         select new
                                         {
                                             pName = d.ProductName,
                                             pPrice = d.ProductPrice,
                                             quantity = f.ProductQuantity,
                                             location = f.LocationName
                                         }).ToList();
            */
            return result;
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
        public static List<Products> ReadAllProducts(Project0Context context)
        {
            return context.Products.ToList();
/*            
            //find all the products in the array
            Console.WriteLine("Reading all products");
            List<Product> prods = new List<Product>();
            foreach (var p in context.Products)
            {
                //Product prod = new Product();
                //prod = Mapper.MapProduct(p);
                prods.Add(Mapper.MapProduct(p));
            }*/  
        }

        public static Product ReadProductById(Project0Context context, int prodId)
        {
            var prod = context.Products
                .Where(x => x.ProductId == prodId).First();

            return Mapper.MapProduct(prod);
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
        public static List<Locations> ReadAllLocations(Project0Context db)
        {
            return db.Locations.ToList();
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
        }
        /// <summary>
        ///takes a location ID and returns the Location object
        /// </summary>
        /// <param name="context"></param>
        /// <param name="locNum"></param>
        /// <returns>Location object</returns>
        public static Location ReadLocationById(Project0Context context, int locNum)
        {
            var loc = context.Locations
                .Where(x => x.LocationId == locNum)
                .FirstOrDefault();

            if (loc == null)
            {   
                throw new NullReferenceException("That location does not exist. Please try again.");
            }

            return Mapper.MapLocation(loc);
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
         
            ///
            ///

        public static bool AddCustomer(Project0Context context, Customer customer)
        {
            //needs to be mapped first!!!
            //Customer
            context.Add(Mapper.MapCustomer(customer));

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("There was an error Adding your account. Please try again with a different name.");
                s_logger.Info(ex);
                return false;
            }
            return true;
        }


        ///<summary>
        ///This method takes the verified customer info from main and inserts it into the DB
        ///</summary>
        public static Customer ReadCustomer(Project0Context context, Customer customer)
        {
            var result = context.Customers
                .Where(c => c.CustomerFirstName == customer.CustomerFirstName && c.CustomerLastName == customer.CustomerLastName)
                .FirstOrDefault();

            if (result == null)
            {
                Console.WriteLine("Sorry, That customer was not found.");
                return null;
            }
            var result1 = Mapper.MapCustomer(result);

            return result1;
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
            Orders orders = new Orders();
            orders.CustomerId = order.CustomerID;
            orders.LocationId = order.LocationID;
            orders.OrderId = order.OrderID;

            foreach (var item in order.itemsOrdered)
            {
                //make ProductsFromOrder object for each product
                ProductsFromOrder prodsInsert = new ProductsFromOrder();
                /* OrderId ProductId  int Quantity */
                prodsInsert.OrderId = order.OrderID;
                prodsInsert.Quantity = item.Value;
                prodsInsert.ProductId = context.Products
                    .Where(x => x.ProductName == item.Key)
                    .Select(x => x.ProductId)
                    .First();

                orders.ProductsFromOrder.Add(prodsInsert);
            }
            context.Add(orders);
            context.SaveChanges();

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
