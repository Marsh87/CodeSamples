using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.OpenClosed.After
{
    public class AreaCalculator
    {
        public double Area(Shape[] shapes )
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.CalculateArea();
            }
            return area;
        }
    }
}
