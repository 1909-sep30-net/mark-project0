using System;
using System.Collections.Generic;
using System.Text;
//using DBLibrary;

namespace ClassLibrary1
{
    public class Customer
    {
        private static int CustomerID = 0;
/*        {
            get { return CustomerID; }
            set { CustomerID = 1; }
        }*/
        public int      CustID              { get; set; }
        public string   CustomerFirstName   { get; set; }
/*        {
            get
            {
                return customerFirstName;
            }
            set 
            {
                customerFirstName = value;
                //validate Here.
                 //THis is a regex found at ...https://www.codeproject.com/Questions/742249/How-to-validate-name-in-Csharp
                //@"^[A-Za-z]+[\s][A-Za-z]+[.][A-Za-z]+$"
                
            }
        }*/
        public string   CustomerLastName    { get; set; }
        public string   CustomerStreet      { get; set; }
        public string   CustomerCity        { get; set; }
        public int      CustomerZipCode     { get; set; }

        //create a customer
        public Customer() {}

        //create a customer with arguments
        public Customer(string fName, string lName, string street, string city, int zip)
        {
            CustomerID++;
            this.CustID             = CustomerID;
            this.CustomerFirstName  = fName;
            this.CustomerLastName   = lName;
            this.CustomerStreet     = street;
            this.CustomerCity       = city;
            this.CustomerZipCode    = zip;
        }
/*  
    ///<summary>
    ///have validation in this function OR in CreateCustomer() as inputs are received?
    ///</summary>
    public static List<Customer> AddCustomerToDB(List<Customer> Customers, Customer cust)
        {
            Console.WriteLine(cust.CustomerFirstName);
            Console.WriteLine(cust.CustomerLastName);
            Console.WriteLine(cust.CustomerStreet);
            Console.WriteLine(cust.CustomerCity);
            //Console.WriteLine(cust.CustomerZipCode);
            //DbLibrary db = new DbLibrary();
            //Customer cust1 = cust;
            Customers.Add(cust);
            return Customers;

        }

        ///<summary>
        ///</summary>
        public static Customer ReadCustomer(List<Customer> Customers, Customer cust)
        {
            return cust;
        }

        ///<summary>
        ///</summary>
        public static List<Customer> ReadAllCustomers(List<Customer> Customers)
        {
            return Customers;
        }

        ///<summary>
        ///</summary>
        public static List<Customer> UpdateCustomer(List<Customer> Customers, Customer customer)
        {
            return Customers;
        }

        ///<summary>
        ///</summary>
        public static List<Customer> DeleteCustomer(Customer customer)
        {
            Customers.Find(customer);//find out how to find and delete from a list.
            return customer;
        }
        */
    }
}
