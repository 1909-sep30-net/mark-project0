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

using System;
using System.Collections.Generic;
using ClassLibrary1;
using DBLibrary;

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
           List<Customer>  customers   = new List<Customer>();
            List<Location>  locations   = new List<Location>();
            List<Product>   products    = new List<Product>();
            List<Order>     orders      = new List<Order>();

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
}
