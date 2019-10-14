using System;
using System.Collections.Generic;


namespace ClassLibrary1
{
    public class Order
    {

       // 
        static int      masterID    = 0;        //this masterID is to give all orders a unique order num in the inventory table
        public int      OrderID     { get; set; }//this is derived from the master ID. each order will have an order id for all products
        public int      CustomerID  { get; set; }
        public string   OrderDate   { get; set; }//store orders as individual products with the CustomerID and Date for later sorting.
        public int      LocationID  { get; set; }
        IDictionary<string, int> itemsOrdered = new Dictionary<string, int>();//to hold the product and quantity


        public Order() { }

        public Order(int orderId, int locationId, int customerId)
        {
            this.OrderID = orderId;
            this.LocationID = locationId;
            this.CustomerID = customerId;
        }


    }
}
