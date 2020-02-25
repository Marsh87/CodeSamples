using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.InterfaceSegregationPrinciple.After
{
    public class ToyPlane:IToy,IFlyable,IMovable
    {
        public void setPrice(double price)
        {
            throw new NotImplementedException();
        }

        public void setColour(string colour)
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
