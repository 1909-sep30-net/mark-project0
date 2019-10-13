using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;
using DbLibrary.Entities;

namespace DbLibrary
{
    public static class Mapper
    {
        public static Customer MapCustomer(Customers customer)
        {
            return new ClassLibrary1.Customer(customer.CustomerFirstName, customer.CustomerLastName);
        }

        public static Customers MapCustomer(Customer customer)
        {
            return new Customers
            {
                CustomerFirstName = customer.CustomerFirstName,
                CustomerLastName = customer.CustomerLastName
            };
        }

        public static Order MapOrder(Orders orders)
        {

        }

        public static Orders MapOrder(Order order)
        {

        }

    }
}
