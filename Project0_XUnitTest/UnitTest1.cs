using System;
using System.Collections.Generic;
using ClassLibrary1;
using DBLibrary;
using Xunit;

namespace Project0_XUnitTest
{


    public class UnitTest1
    {
        List<Customer> testCustomers = new List<Customer>();
        List<Location> testLocations = new List<Location>();
        List<Product> testProducts = new List<Product>();
        List<Order> testOrders = new List<Order>();

        [Fact]
        public void Test1()
        {
            //arrange
            Product product0 = new Product("apples", 10, 10);

            //act
            var test = product0.ProductName;

            //assert
            Assert.Equal(expected: test, actual: "apples");
        }


        [Fact]
        public void Test2()
        {
            //arrange
            Product product0 = new Product("apples", 10, 10);
            Product product1 = new Product("oranges", 11, 11);
            Product product2 = new Product("zuccini", 12, 12);

            //act
            DbLibrary.AddProduct(product0);
            DbLibrary.AddProduct(product1);
            DbLibrary.AddProduct(product2);

            //assert
            Assert.Equal(expected: DbLibrary.products.Count, actual: 3);
        }

        /* 

                    products = DbLibrary.ReadAllProducts();
                    Console.WriteLine(products.Count);
                    foreach (Product x in products)
                    {
                        Console.WriteLine($"{x.prodID}, {x.ProductName}, {x.ProductPrice}, {x.ProductQuantity}");
                        Console.WriteLine();
                    }
                }*/

        [Fact]
        public void Test3()
        {
            //arrange
            Customer customer1 = new Customer("Mark", "Moore", "432 MIllbrook Ln.", "Crowley", 11111);

            //act
            var test = customer1.CustomerLastName;

            //assert
            Assert.Equal(expected: test, actual: "Moore");
        }

        [Fact]
        public void Test4()
        {
            //arrange
            Customer customer1 = new Customer("Mark", "Moore", "432 MIllbrook Ln.", "Crowley", 11111);
            Customer customer2 = new Customer("Ethan", "Moore", "1 MIllbrook Ln.", "Euless", 22222);
            Customer customer3 = new Customer("Hope", "Moore", "2 MIllbrook Ln.", "Bedford", 33333);

            //act
            DbLibrary.AddCustomer(customer1);
            DbLibrary.AddCustomer(customer2);
            DbLibrary.AddCustomer(customer3);

            //assert
            Assert.Equal(expected: DbLibrary.customers.Count, actual: 3);

        }

        /*            testCustomers = DbLibrary.ReadAllCustomers();
                    Console.WriteLine(testCustomers.Count);
                    foreach (Customer x in testCustomers)
                    {
                        Console.WriteLine($"{x.CustID}, {x.CustomerFirstName}, {x.CustomerLastName}, {x.CustomerStreet}, {x.CustomerCity}, {x.CustomerZipCode}");
                        Console.WriteLine();
                    }*/



        [Fact]
        public void Test5()
        {
            //arrange
            Location Location1 = new Location("Fort Worth", "432 MIllbrook Ln.", "For Worth", 44444);

            //act
            var test = Location1.LocationCity;

            //assert
            Assert.Equal(expected: test, actual: "Fort Worth");
        }




        [Fact]
        public void Test6()
        {
            //arrange
            Location Location1 = new Location("Fort Worth", "432 MIllbrook Ln.", "For Worth", 44444);
            Location Location2 = new Location("Dallas", "1 MIllbrook Ln.", "Dallas", 55555);
            Location Location3 = new Location("Burleson", "2 MIllbrook Ln.", "Burleson", 66666);

            //act
            DbLibrary.AddLocation(Location1);
            DbLibrary.AddLocation(Location2);
            DbLibrary.AddLocation(Location3);

            //assert
            testLocations = DbLibrary.ReadAllLocations();
            Assert.Equal(expected: DbLibrary.locations.Count, actual: 3);

        }

        [Fact]
        public void Test7()
        {
            //arrange
            Order order1 = new Order(11, "Mary 27, 1979", 22);

            //act
            var test = order1.OrderDate;

            //assert
            Assert.Equal(expected: test, actual: "Mary 27, 1979");
        }




        [Fact]
        public void Test8()
        {
            //arrange
            Order order1 = new Order(11, "May 27, 1979", 22);
            Order order2 = new Order(12, "June 27, 1979", 33);
            Order order3 = new Order(13, "July 27, 1979", 44);


            //act
            DbLibrary.AddOrder(order1);
            DbLibrary.AddOrder(order2);
            DbLibrary.AddOrder(order3);

            //assert
            testLocations = DbLibrary.ReadAllLocations();
            Assert.Equal(expected: DbLibrary.locations.Count, actual: 3);

        }
    }
}


/*Console.WriteLine(testLocations.Count);
            foreach (Location x in testLocations)
            {
                Console.WriteLine($"{x.locID}, {x.LocationName}, {x.LocationStreet}, {x.LocationCity}, {x.LocationZip}");
                Console.WriteLine();
            }*/


/*using System;
using System.Collections.Generic;
using System.Text;
using Sequences.Library;
using Xunit;

namespace Sequences.Tests
{
    public class StringSequenceTests
    {
        // these attributes like [Fact] tell xUnit that this is a test method.

        [Theory]
        [InlineData("abc")]
        [InlineData("")]
        [InlineData("😊😂😁")]
        [InlineData(null)]
        public void AddShouldAdd(string item)
        {
            // arrange (any setup necessary to prepare for the behavior to test)
            var seq = new StringSequence();

            // act (do the thing you want to test)
            seq.Add(item);

            // assert (verify that the behavior was as expected)
            Assert.Equal(expected: item, actual: seq[0]);
        }

        [Fact]
        public void AddShouldAddInConsistentOrder()
        {
            // arrange
            var seq = new StringSequence();

            // act
            seq.Add("abc");
            seq.Add("def");

            // assert
            Assert.Equal(expected: "abc", actual: seq[0]);
            Assert.Equal(expected: "def", actual: seq[1]);
        }

        [Fact]
        public void AccessOutOfBoundsShouldThrow()
        {
            // arrange
            var seq = new StringSequence();

            // act, assert (that an exception is thrown when some code runs.)
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() =>
            {
                var x = seq[0];
            });
        }

        [Fact]
        public void LongestStringShouldReturnLongest()
        {
            // arrange
            var seq = new StringSequence();
            seq.Add("");
            seq.Add("abc");
            seq.Add("0123456789");
            seq.Add("a");

            // act
            var longest = seq.LongestString();

            // assert
            Assert.Equal("0123456789", longest);
        }
    }
}
*/