using DynamicTypeCSharpExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTypeCSharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dynamic types change types at run-time based on the assigned value

            dynamic age = 34;
            Console.WriteLine("Value: {0}, Type {1}", age, age.GetType());

            dynamic profit = 100.25;
            Console.WriteLine("Value: {0}, Type {1}", profit, profit.GetType());

            dynamic greeting = "Hello";
            Console.WriteLine("Value: {0}, Type {1}", greeting, greeting.GetType());

            dynamic  todaysDate = DateTime.Now;
            Console.WriteLine("Value: {0}, Type {1}",todaysDate, todaysDate.GetType());

            profit = 1;
            Console.WriteLine("Value: {0}, Type {1}", profit, profit.GetType());

            greeting = 45m;
            Console.WriteLine("Value: {0}, Type {1}", greeting, greeting.GetType());

            //Dynamic type conversion
            dynamic value = 100;
            int i =value;

            value = "Hello";
            string greet =value;

            value = DateTime.Now;
            DateTime today = value;

            dynamic customer = new Customer("Mahesh","Moodley","083");
            Console.WriteLine(customer.GetFullName());

            customer.GetCellNumber(); //run time error, no compile time error 

            Console.ReadKey();
        }
    }
}
