using System;

namespace ClassLibrary1
{
    public class Orders
    {
        static int      OrderID = 0;
        public int      ProductID   { get; set; }// FK
        public string   ProductName { get; set; }
        public int      CustomerID  { get; set; }
        public string   OrderDate   { get; set; }//store orders as individual products with the CustomerID and Date for later sorting.
        public int      LocationID  { get; set; }
        //public string   OrderTime   { get; set; }

        ///<summary>
        ///</summary>
        public static void CreateAndAddOrder()
        {

        }

        ///<summary>
        ///</summary>
        public static void ReadOrder()
        {

        }

        ///<summary>
        ///</summary>
        public static void UpdateOrder()
        {

        }

        ///<summary>
        ///</summary>
        public static void DeleteOrder()
        {

        }

    }
}
