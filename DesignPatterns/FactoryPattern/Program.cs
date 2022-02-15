using System;

namespace FactoryPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*https://www.c-sharpcorner.com/article/factory-method-design-pattern-in-c-sharp/
              Factory Method is a Design Pattern which defines an interface for creating an object but lets the classes that implement the interface decide which class to instantiate.
               Factory Pattern lets a class postpone instantiation to sub-classes.The factory pattern is used to replace class constructors, 
               abstracting the process of object generation so that the type of the object instantiated can be determined at run-time.
               
               The classes and objects participating in the above UML class diagram are as follows:
               Product
                
               This defines the interface of objects the factory method creates
               ConcreteProduct
                
               This is a class that implements the Product interface.
               Creator
                
               This is an abstract class and declares the factory method, which returns an object of type Product.
                
               This may also define a default implementation of the factory method that returns a default ConcreteProduct object.
               This may call the factory method to create a Product object.
               ConcreteCreator
                
               This is a class that implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.
             */
            
            CardFactory factory = null;
            Console.Write("Enter the card type you would like to visit: ");
            string car = Console.ReadLine();

            switch (car.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackFactory(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    factory = new PlatinumFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();
        }
    }
}