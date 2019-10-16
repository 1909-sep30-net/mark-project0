/*     functionality
       X - place orders to store locations for customers
       X - add a new customer
       X - search customers by name - DONE AS PART OF LOGGING IN.
       display details of an order
       X - display all order history of a store location
       X - display all order history of a customer
       X - input validation
       X - exception handling
       X - persistent data(SQL); no products, prices, customers, etc. hardcoded in C#
       X - logging
       (optional: order history can be sorted by earliest, latest, cheapest, most expensive)
       (optional: get a suggested order for a customer based on his order history)
                       (optional: save some or all data to disk in JSON format)
       (optional: load some or all data from disk)
       (optional: display some statistics based on order history)
*/

//this is the CONNECTIONSTRING to connect Entity Framework Core.
/*
 * dotnet ef dbcontext scaffold "Server=tcp:1909escalonasql.database.windows.net,1433;Initial Catalog=PokemonDb;Persist Security Info=False;User ID=nick;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer --startup-project ../EfDemo.App --force --output-dir Entities
* make sure to edit with personal info.*/

using NLog;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ClassLibrary1;
using DBLibrary;
using DbLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

//using System.IO;
//using System.Security;
//using System.Xml.Serialization;

namespace mark_project0
{
    class Program
    {
        private static readonly NLog.ILogger s_logger =LogManager.GetCurrentClassLogger();

        //function to get user info
        static Customer RegisterUser() //this needs to input the new user in the DB
        {

            //Customer customer1 = new Customer(fName, lName);
            Customer customer1 = new Customer();
            bool success = false;
            while (success == false)
            {
                try
                {
                    Console.WriteLine("\nPlease enter your First Name.");
                    string fName = Console.ReadLine();
                    customer1.CustomerFirstName = fName;
                    success = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    s_logger.Info(ex);
                }
            }

            success = false;
            while (success == false)
            {
                try
                {
                    Console.WriteLine("\nPlease enter your Last Name.");
                    string lName = Console.ReadLine();
                    customer1.CustomerLastName = lName;
                    success = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    s_logger.Info(ex);
                }
            }
            return customer1;
        }//END OF Register User()

        static Customer SignInUser(Project0Context context)
        {
            Customer customer1 = new Customer();
            bool success = false;
            while (success == false)
            {
                try
                {
                    Console.WriteLine("\nPlease enter your First Name.");
                    string fName = Console.ReadLine();
                    customer1.CustomerFirstName = fName;
                    success = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    s_logger.Info(ex);
                }
            }

            success = false;
            while (success == false)
            {
                try
                {
                    Console.WriteLine("\nPlease enter your Last Name.");
                    string lName = Console.ReadLine();
                    customer1.CustomerLastName = lName;
                    success = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    s_logger.Info(ex);
                }
            }
            return customer1;

        }//END OF SignInUser()

        static void Main(string[] args)
        {
            bool finished = false;
            var optionsBuilder = new DbContextOptionsBuilder<Project0Context>();
            optionsBuilder.UseSqlServer(config.connectionString);
            using (var db = new Project0Context(optionsBuilder.Options))
            {
                Customer customer = new Customer();
                Order order = new Order();
                Location location = new Location();

                while (finished.Equals(false))
                {


                    /*******************************log in or register the user*******************/
                    string userType;
                    do
                    {
                        Console.WriteLine("Are you a returning user of do you need to register?");
                        Console.WriteLine("\n\n\tA - Register.\n\tB - Returning User.");
                        userType = Console.ReadLine();
                        userType = userType.ToUpper();  //to accept upper and lower case letters.
                    } while (!(userType.Equals("A") || userType.Equals("B")));

                    switch (userType)
                    {
                        case "A":
                            bool custExists = false;
                            while (custExists == false)
                            {
                                customer = RegisterUser();       //register the user
                                custExists = DBRepository.AddCustomer(db, customer);
                                //add the new, VALIDATED, user to the DB. 
                                //CHECK to make sure this User doesn't already exist.
                            }
                            break;
                        case "B":
                            string custExists2 = null;
                            while (custExists2 == null)
                            {
                                customer = SignInUser(db); //sign the user in.
                                customer = DBRepository.ReadCustomer(db, customer);
                                if (customer != null)
                                {
                                    custExists2 = "good";
                                }
                            }
                            break;
                    }

                    /***************************CHOOSE TO SEARCH OR PLACE AN ORDER***********************/
                    bool quitter1 = false;
                    do 
                    {
                        do
                        {
                            Console.WriteLine("\n Would you like to continue to the ordering process, " +
                                "or would you like to search for things??");
                            Console.WriteLine("\n\n\tA - Proceed to order.\n\tB - Search.");
                            userType = Console.ReadLine();
                            userType = userType.ToUpper();  //to accept upper and lower case letters.
                        } while (!(userType.Equals("A") || userType.Equals("B")));

                        switch (userType)
                        {
                            case "A":
                                Console.WriteLine("\n\t.......Proceeding to the ordering page.......");
                                quitter1 = true;
                                break;
                            case "B":
                                searching.goSearching(db);
                                break;
                        }
                        if (quitter1 == true)
                        {
                            break;
                        }

                        Console.WriteLine("Would you like to START OVER or QUIT?\n\t\tType START OVER or QUIT");
                        string answer = Console.ReadLine();
                        answer = answer.ToLower();
                        if (answer.Equals("start over"))
                        {
                            //continue;
                        }
                        else
                        {
                            quitter1 = true;
                            System.Environment.Exit(0);
                        }

                    } while (quitter1 == false);







                    /**********************choose the location*****/
                    var allLocations = DBRepository.ReadAllLocations(db);//returns a list of locations
                    string locChoice;
                    int finalLocChoice;
                    do
                    {
                        foreach (var item in allLocations)
                        {
                            Console.WriteLine($"{item.LocationId} - {item.LocationName}\n");
                        }
                        Console.WriteLine("Please choose a number from the above list.");
                        locChoice = Console.ReadLine();
                        finalLocChoice = Convert.ToInt32(locChoice);
                        location = DBRepository.ReadLocationById(db, finalLocChoice);
                    } while (location == null);

                    Console.WriteLine($"You chose our {location.LocationName} location. Happy shopping!");


                    /*************************Make the order****************************/
                    //int prodChoice;
                    string choice;
                    string choiceQuantity;
                    int choiceQuantityInt;
                    //get all the products in the chosen locations inventory
                    var allProductsInInventory = DBRepository.ReadLocationInventory(db, location.LocationName);

                    var allProducts = DBRepository.ReadAllProducts(db);


                    do
                    {
                        Console.WriteLine("\n\tPlease choose from the available product numbers.\n\tEnter a product number and hit enter." +
                            "\n\tYou may keep placing products until\n\tyou enter 'checkout' to check out.");
                        
                        //display all products from this location.
                        foreach (var item in allProductsInInventory)
                        {
                            int testNum = item.ProductId;
                            Product prod = DBRepository.ReadProductById( db,item.ProductId);
                            //Console.WriteLine($"this is item.ProductID=>{item.ProductId} ... This is testNum=>{testNum} ...this is prod.ProductID=>{prod.ProductID}");
                            Console.WriteLine($"\t{prod.ProductID} - {prod.ProductName} = {prod.ProductPrice}. {item.ProductQuantity} in stock.");
                        }
                        Console.WriteLine("\tcheckout - Check out.");
                        choice = Console.ReadLine();
                        choice = choice.ToLower();
                        if (choice.Equals("checkout"))
                        {
                            continue;
                        }
                        int prodIdChoice;
                        prodIdChoice = Convert.ToInt32(choice);
                        
                        //make sure the name entered is in the list.
                        if (allProductsInInventory.Exists(x => x.ProductId == prodIdChoice) == false)
                        {
                            Console.WriteLine("\n\t\tYour choice is not in the list.");
                            continue;
                        }
                        else
                        {
                            //get the chosen named Product from the Products table.
                            Inventory choice3 = allProductsInInventory.Find(x => x.ProductId.Equals(prodIdChoice));
                            Product prod = DBRepository.ReadProductById(db, choice3.ProductId);


                            Console.WriteLine($"\nHow Many {prod.ProductName}'s would you like? There are {choice3.ProductQuantity} available");
                            
                            //Console.WriteLine($"found product => {choice3.ProductName} - {choice3.ProductPrice} - {choice3.ProductQuantity}");
                            choiceQuantity = Console.ReadLine();
                            choiceQuantityInt = Convert.ToInt32(choiceQuantity);
                            
                            if(choiceQuantityInt > choice3.ProductQuantity)
                            {
                                Console.WriteLine($"\nThere are not enough {prod.ProductName} available. \nThe maximum you may add is {choice3.ProductQuantity}. Try again.\n");
                                continue;
                            }
                            else
                            {
                                //check if the item has already been ordered. if not, add it and decrement amount available.
                                if (order.itemsOrdered.ContainsKey(prod.ProductName) == false)
                                {
                                    order.itemsOrdered.Add(prod.ProductName, choiceQuantityInt);
                                    choice3.ProductQuantity -= choiceQuantityInt;//decrement amount in context
                                }
                                else
                                {
                                    //add the previously ordered quantity back to the inventory then subtract the newly ordered amount
                                    choice3.ProductQuantity = choice3.ProductQuantity + order.itemsOrdered[prod.ProductName];
                                    order.itemsOrdered[prod.ProductName] = choiceQuantityInt;
                                    choice3.ProductQuantity = choice3.ProductQuantity - choiceQuantityInt;//decrement amount in context
                                    Console.WriteLine($"\n\tYour desired amount of {prod.ProductName} has been updated to {order.itemsOrdered[prod.ProductName]}");
                                }
                            }
                        }
                        //print current state of customers order
                        Console.WriteLine("\nYou current order is... ");
                        foreach (var item in order.itemsOrdered)
                        {
                            Console.WriteLine($"=== {item.Key} === {item.Value}=");
                        }

                    } while (!choice.Equals("checkout"));//end of ordering loop
                    order.LocationID = location.locID;
                    order.CustomerID = customer.CustID;
                    DBRepository.AddOrder(db,order);
                    db.SaveChanges();

                    finished = true;
                }//END OF WHILE LOOP
                Console.WriteLine("\n\n\t============= Thank You for shopping with us. =============\n");
            }//END OF USING
        }//END OF MAIN
    }//END OF CLASS
}//END OF NAMESPACE
