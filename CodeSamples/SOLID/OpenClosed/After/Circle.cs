using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.OpenClosed.After
{
    public class Circle: Shape
    {
        public  double Radius { get; set; }
        public override double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
