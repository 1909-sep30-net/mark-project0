﻿using System;
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
            return new Customer(customer.CustomerId, customer.CustomerFirstName, customer.CustomerLastName);
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
        //public static Order MapOrder(Orders orders)
        //{//this will return the object/ the lother function will thill have to loop to popoulate the list of products. 
        //    Order ord = new Order(orders.OrderId, orders.LocationId, orders.CustomerId);
            

        //    return ord;
        //}

        //public static Order MapProductsToOrder(Project0Context db, Order order)
        //{
        //    var products = db.ProductsFromOrder
        //        .Include(o => o.ProductName)
        //        .Where()
        //        }

        //CLASS TO ENTITY
        /*        public static Orders MapOrder(Order order)//need to somehow get the product ID for each product
                {
                    //create Orders object to fill the Orders table.
                    Orders ord = new Orders();
                    ord.OrderId = order.OrderID;
                    ord.LocationId = order.LocationID;
                    ord.CustomerId = order.CustomerID;
                    //ProductsFromOrder prods = new ProductsFromOrder();

                    //first copy ordered products into the 
                    foreach (KeyValuePair<string, int> item in order.itemsOrdered)
                    {
                        ProductsFromOrder prods = new ProductsFromOrder();
                        prods.OrderId = order.OrderID;
                        prods.ProductId = ;
                        prods.Quantity = ;
                        prods.Order = item.Key;
                        = item.Value);
                    }

                    //return new Orders
                    //{
                    //    OrderId = order.OrderID,
                    //    CustomerId = order.CustomerID,
                    //    LocationId = order.LocationID,

                    //    ProductsFromOrder = 
                    //};
                }*/

        //ENTITY TO CLASS
        public static Product MapProduct(Products products)
        {//call constructor
            return new Product(products.ProductId, products.ProductName, Convert.ToInt32(products.ProductPrice));
        }

        //CLASS TO ENTITY
        public static Products MapProduct(Product product)
        {//create new product.
            return new Products
            {
                ProductId = product.ProductID,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice
            };

        }

        //ENTITY TO CLASS
        public static Location MapLocation(Locations locations)
        {
            return new Location(locations.LocationId, locations.LocationName);
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
