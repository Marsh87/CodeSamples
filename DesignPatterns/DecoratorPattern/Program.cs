using System;

namespace DecoratorPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        { /*https://www.c-sharpcorner.com/UploadFile/damubetha/decorator-pattern-in-csharp/
           The idea of the Decorator Pattern is to wrap an existing class, add other functionality to it, then expose the same interface to the outside world. 
           Because of this our decorator exactly looks like the original class to the people who are using it.
           It is used to extend or alter the functionality at runtime. It does this by wrapping them in an object of the decorator class without modifying the original object. So it can be called a wrapper pattern.*/
            /*
             Advantages of Decorator Pattern
            Adds functionality to existing objects dynamically
            Alternative to sub classing
            Flexible design
            Supports Open Closed Principle
            When to use Decorator Pattern
            Legacy System
            Controls
            Sealed Classes
             */
            ICar economyCar = new EconomyCar();   
  
            //Wrp EconomyCar instancw with BasicAccessories.   
            CarAccessoriesDecorator accessoriesDecorator = new BasicAccessories(economyCar);   
  
            //Wrap EconomyCar instance with AdvancedAccessories instance.   
            accessoriesDecorator = new AdvancedAccessories(accessoriesDecorator);   
  
            Console.Write("Car Detials: " + accessoriesDecorator.GetDescription());   
            Console.WriteLine("\n\n");   
            Console.Write("Total Price: " + accessoriesDecorator.GetCost());   
  
            Console.Read();   
        }
    }
}