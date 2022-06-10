using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double x, double y)
        {
            Length = x;
            Width = y;
        }

        double IShape.CalculateArea()
        {
            return Length * Width;
        }

        double IShape.CalculatePerimeter()
        {
            return 2*(Length+Width);
        }
    }
}
