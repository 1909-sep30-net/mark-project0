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


        public Location()
        {

        }

        public Location(string loc, string street, string city, int zip)
        {
            LocationID++;
            locID = LocationID;
            LocationName = loc;
            LocationStreet = street;
            LocationCity = city;
            LocationZip = zip;
        }
/*
        ///<summary>
        ///</summary>
        public static List<Location> AddLocation(List<Location> locations, Location location )
        {
            //{ "Dallas", "Fort Worth", "Crowley", "Burleson", "Joshua" };
            locations.Add(location);
            return locations;
        }

        ///<summary>
        ///</summary>
        public static List<Location> ReadAllLocations(List<Location> locations)
        {
            //make a list of locations
            return locations;
        }

        ///<summary>
        ///</summary>
        public static Location ReadOneLocation(List<Location> locations, Location location)//this might be accomplished with SearchLocations() below
        {
            return location;
        }

        ///<summary>
        ///</summary>
        public static List<Location> UpdateLocation(List<Location> locations, Location location)
        {
            return locations;
        }

        ///<summary>
        ///</summary>
        public static List<Location> DeleteLocation(List<Location> locations, Location location)
        {
            return locations;
        }

        ///<summary>
        ///</summary>
        public static Location SearchLocations(List<Location> locations, Location location)
        {
            return location;
        }
*/
    }
}
