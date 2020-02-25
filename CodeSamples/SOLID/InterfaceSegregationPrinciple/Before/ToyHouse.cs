using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.InterfaceSegregationPrinciple.Before
{
    public class ToyHouse:IWrongToy
    {
        int _price;
        String _color;
        public void setPrice(int price)
        {
            price = this._price;
        }

        public void setColor(string color)
        {
            color = this._color;
        }

        public void move()
        {
          throw new Exception("Not Allowed");
        }

        public void fly()
        {
            throw new Exception("Not Allowed");
        }
    }
}
