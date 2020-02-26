using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.OpenClosed.Before
{
    public class OpenClosedBefore
    {
        private class Rectangle
        {
            public  double Width { get; set; }
            public  double Height { get; set; }
        }

        private class Circle
        {
            public double  Radius { get; set; }
        }


        //Existing
        private class AreaCalculator
        {
            public double Area(Rectangle[] shapes)
            {
                double area = 0;
                foreach (var shape in shapes)
                {
                    if (shape.GetType()  == typeof(Rectangle))
                    {
                        area += shape.Width * shape.Height;
                    }
                    else
                    {
                        Circle circle = new Circle();
                        area += circle.Radius * circle.Radius * Math.PI;
                    }
                }
                return area;
            }
        }
    }
}
