/*     functionality
       place orders to store locations for customers
       add a new customer
       search customers by name
       display details of an order
       display all order history of a store location
       display all order history of a customer
       input validation
       exception handling
       persistent data(SQL); no products, prices, customers, etc. hardcoded in C#
       logging
       (optional: order history can be sorted by earliest, latest, cheapest, most expensive)
       (optional: get a suggested order for a customer based on his order history)
                       (optional: save some or all data to disk in JSON format)
       (optional: load some or all data from disk)
       (optional: display some statistics based on order history)
*/


//THIS IS THE SQL CONNECTION STRING =>  
// Server=tcp:mooremark.database.windows.net,1433;Initial Catalog=Project0;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
// MAKE SURE TO FILL IN THE THE CORRECT PERSONAL DETAILS

//this is to connect Entity Framework Core.
/*
 * dotnet ef dbcontext scaffold "Server=tcp:1909escalonasql.database.windows.net,1433;Initial Catalog=PokemonDb;Persist Security Info=False;User ID=nick;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer --startup-project ../EfDemo.App --force --output-dir Entities
* make sure to edit with personal info.*/

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;
using ClassLibrary1;
using DbLibrary;
using DbLibrary.Entities;


namespace mark_project0
{
    class Program
    {

        //function to get user info
        static Customer RegisterUser()
        {
            //have user enter all info.
            Console.WriteLine("\nPlease enter your Customer First Name.");
            string fName = Console.ReadLine();
            Console.WriteLine("Please enter your Customer Last Name.");
            string lName = Console.ReadLine();
            Console.WriteLine("Please enter your Street and home number.");
            string street = Console.ReadLine();
            Console.WriteLine("Please enter your City.");
            string city = Console.ReadLine();
            Console.WriteLine("Please enter your Zip Code.");
            int zip = Convert.ToInt32(Console.ReadLine());

            Customer customer1 = new Customer(fName, lName, street, city, zip);
            //customer1 = Customer.CreateCustomer(customer1);
            return customer1;
        }

        static void Main(string[] args)
        {
            /*var connectionString = config.connectionString;

            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using DbCommand command = new SqlCommand("SELECT * FROM Customers;", connection);
                using DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Console.WriteLine("Successfully accessed the DB");
                }
                else
                {
                    Console.WriteLine("DID NOT successfully access the DB");
                }

                await connection.CloseAsync();
            }
            catch(SqlException ex)
            {
                Console.WriteLine($"\n\tError => {ex.Message}\n");
            }*/
           
            List<Customer>  customers   = new List<Customer>();
            List<Location>  locations   = new List<Location>();
            List<Product>   products    = new List<Product>();
            List<Order>     orders      = new List<Order>();
            var db = new Project0Context();

            //Products product1 = new Products();
            /*            product1.ProductName = "orange";
                        product1.ProductPrice = 12;
                        DBLibrary.DbLibrary.AddProduct(product1);*/

            //test ReadProducts()
            //product1 = DBLibrary.DbLibrary.ReadProduct(product1);
            //Console.WriteLine($"This is Product1 =>{product1.ProductId} - {product1.ProductName} - {product1.ProductPrice}");

            //test ReadAllProducts
            var prodList = DBLibrary.DbLibrary.ReadAllProducts(db);
            foreach (var item in prodList)
            {
                Console.WriteLine($"==>{item.ProductId} - {item.ProductName} - {item.ProductPrice} - {item.DateModified}<==");
            }

            //test UpdateProduct

           




            Console.WriteLine("\nDONE\n");
        }

        /*
        Product product0 = new Product("apples",10,10);
        Product product1 = new Product("oranges",11,11);
        Product product2 = new Product("zuccini",12,12);

        DbLibrary.AddProduct(product0);
        DbLibrary.AddProduct(product1);
        DbLibrary.AddProduct(product2);

        products = DbLibrary.ReadAllProducts();
        Console.WriteLine(products.Count);
        foreach(Product x in products)
        {
            Console.WriteLine($"{x.prodID}, {x.ProductName}, {x.ProductPrice}, {x.ProductQuantity}");
            Console.WriteLine();
        }
*/




        /*            Customer customer1 = new Customer("Mark", "Moore", "432 MIllbrook Ln.","Crowley", 11111);
                    Customer customer2 = new Customer("Ethan", "Moore", "1 MIllbrook Ln.", "Euless", 22222);
                    Customer customer3 = new Customer("Hope", "Moore", "2 MIllbrook Ln.", "Bedford", 33333);

                    DbLibrary.AddCustomer(customer1);
                    DbLibrary.AddCustomer(customer2);
                    DbLibrary.AddCustomer(customer3);

                    customers = DbLibrary.ReadAllCustomers();
                    Console.WriteLine(customers.Count);
                    foreach(Customer x in customers)
                    {
                        Console.WriteLine($"{x.CustID}, {x.CustomerFirstName}, {x.CustomerLastName}, {x.CustomerStreet}, {x.CustomerCity}, {x.CustomerZipCode}");
                        Console.WriteLine();
                    }
        */

        /*
                    //get the data and THEN send it all into the object to be verified
                    Console.WriteLine("Welcome to your personal online shopping App!");
                    Console.WriteLine("Please register or log in.\n\nEnter 1 for Current User\n Enter 2 to register.");
                    int user;
                    do
                    {
                        user = Convert.ToInt32(Console.ReadLine()); //get a choice from the user
                    } while (user != 1 || user != 2);

                    switch (user)
                    {
                        case 1:Customer newUser = RegisterUser();//send to register page

                            break;
                        case 2://send to log in login page
                            break;
                    }

                    Console.WriteLine("Please Choose a store location.");

                    //get store locations with a function
                    //Location loc = new Location();
                    //List<Location> locations = ClassLibrary1.Location.ReadAllLocations(locations);

                    int store;
                    do
                    {
                        store = Convert.ToInt32(Console.ReadLine()); //get a choice from the user
                    } while (store != 1 || store != 2);

                    switch (store)
                    {
                        case 1:
                            RegisterUser();//send to register page
                            break;

                        case 2://send to log in login page
                            break;


            */
    }
}
