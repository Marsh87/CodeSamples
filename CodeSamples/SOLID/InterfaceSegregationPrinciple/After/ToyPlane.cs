using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.InterfaceSegregationPrinciple.After
{
    // TODO please can we have another concrete toy that doesn't implement all interfaces
    // TODO I know that the point isn't to implement actual toy functionality, however please
    //      don't throw NotImplemented exceptions as that is normally what is done when
    //      the interface segregation principle is violated. Perhaps do a console write
    //      or a comment saying "some valid implementation"
    public class ToyPlane:IToy,IFlyable,IMovable
    {
        private double _price;
        private string _colour;
        public void setPrice(double price)
        {
            _price = price;
        }

        public void setColour(string colour)
        {
            _colour = colour;
        }

        public void Fly()
        {
            Console.WriteLine("I am flying");
        }

        public void Move()
        {
            Console.WriteLine("I am moving");
        }
    }
}
