using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.InterfaceSegregationPrinciple.After
{
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
