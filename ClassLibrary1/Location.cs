using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Location
    {

        static int      LocationID      = 0;
        public int      locID           { get; set; }
        public string   LocationName    { get; set; }
        public string   LocationStreet  { get; set; }
        public string   LocationCity    { get; set; }
        public int      LocationZip     { get; set; }


        public Location()  { }

        public Location(string loc, string street, string city, int zip)
        {
            LocationID++;
            locID = LocationID;
            LocationName = loc;
            LocationStreet = street;
            LocationCity = city;
            LocationZip = zip;
        }
    }
}
