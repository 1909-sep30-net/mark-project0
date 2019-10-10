using System;
using System.Collections.Generic;


namespace ClassLibrary1
{
    public class Order
    {

       // 
        static int      masterID    = 0;
        public int      OrderID     { get; set; }
        public int      CustomerID  { get; set; }
        public string   OrderDate   { get; set; }//store orders as individual products with the CustomerID and Date for later sorting.
        public int      LocationID  { get; set; }
        IDictionary<string, int> itemsOrdered = new Dictionary<string, int>();//to hold the product and quantity


        //Needs constructors!



/*
        public static List<Order> AddOrder(List<Order> orders, Order order)
        {
            return orders;
        }

        ///<summary>
        ///</summary>
        public static List<Order> ReadOrder(List<Order> orders, Order order)
        {
            return orders;
        }

        ///<summary>
        ///</summary>
        public static List<Order> ReadAllOrders(List<Order> orders, Order order)
        {
            return orders;
        }

        ///<summary>
        ///</summary>
        public static List<Order> UpdateOrder(List<Order> orders, Order order)
        {
            return orders;
        }

        ///<summary>
        ///</summary>
        public static List<Order> DeleteOrder(List<Order> orders, Order order)
        {
            return orders;
        }
*/
    }
}
