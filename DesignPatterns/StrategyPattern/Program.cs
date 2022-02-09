using System;
using StrategyPattern.Properties;

namespace StrategyPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*This pattern falls under the category of behavioral pattern and as the name suggests, it allows clients to choose an algorithm from a set of algorithms at run time.
             Strategy pattern defines a family of algorithms, encapsulates each one of them and makes them interchangeable at run time within that family.
              Family of Algorithms: This means this pattern provides a set of algorithms using one of which at run time you can achieve the desired output.
              Encapsulate each one of the: This pattern allows you to place your algorithms in different classes (encapsulate them).
              Makes the algorithm interchangeable: The beauty with strategy pattern is that we can select at run time which algorithm we want to apply to our object and can also replace them with one another.
             */

            Console.WriteLine(
                "Hello!, Please select the mode of transport to get the travel time between source and destination: \nCar \nBike \nBus");
            var userStrategy = Console.ReadLine().ToLower();
            Console.WriteLine("\nUser has selected *" + userStrategy + "* as mode of transport\n");
            Console.WriteLine(
                "\n*****************************************************************************************************\n");
            switch (userStrategy)
            {
                case "car":
                    new TravelStrategy(new Car()).GetTravelTime("Point A", "Point B");
                    break;
                case "bike":
                    new TravelStrategy(new Bike()).GetTravelTime("Point A", "Point B");
                    break;
                case "bus":
                    new TravelStrategy(new Bus()).GetTravelTime("Point A", "Point B");
                    break;
                default:
                    Console.WriteLine("You have chosen an invalid mode of transport.");
                    break;
            }
        }
    }
}