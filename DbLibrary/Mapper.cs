using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;
using DbLibrary.Entities;

namespace DBLibrary
{
    public static class Mapper
    {
        //ENTITY TO CLASS
        public static Customer MapCustomer(Customers customer)
        {
            return new Customer(customer.CustomerFirstName, customer.CustomerLastName);
        }

        //CLASS TO ENTITY
        public static Customers MapCustomer(Customer customer)
        {
            return new Customers
            {
                CustomerFirstName = customer.CustomerFirstName,
                CustomerLastName = customer.CustomerLastName
            };
        }

        //ENTITY TO CLASS
        public static Order MapOrder(Orders orders)
        {//this will return the object/ the lother function will thill have to loop to popoulate the list of products. 
            return new Order(orders.OrderId, orders.LocationId, orders.CustomerId);
        }

        //CLASS TO ENTITY
        public static Orders MapOrder(Order order)
        {
            return new Orders
            {
                OrderId = order.OrderID,
                CustomerId = order.CustomerID,
                LocationId = order.LocationID
            };
        }

        //ENTITY TO CLASS
        public static Product MapProduct(Products products)
        {//call constructor
            return new Product(products.ProductName, Convert.ToInt32(products.ProductPrice));
        }

        //CLASS TO ENTITY
        public static Products MapProduct(Product product)
        {//create new product.
            return new Products
            {
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice
            };

        }

        //ENTITY TO CLASS
        public static Location MapLocation(Locations locations)
        {
            Console.WriteLine($"CITY =>{locations.LocationName }");
            string name = locations.LocationName;
            Console.WriteLine(name);
            Location n = new Location(name);
            return n;
        }

        //CLASS TO ENTITY
        public static Locations MapLocation(Location location)
        {
            return new Locations
            {
                LocationName = location.LocationName
            };
        }

        //this method will transfer the orders to a list.

    }
}
