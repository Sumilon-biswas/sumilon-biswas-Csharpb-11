using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;


namespace Task3
{
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }


        public Triangle(double x, double y, double z)
        {
            Base = x;
            Height = y;
            Width = z;
        }

        double IShape.CalculateArea()
        {
            return (Height * Base) / 2;
        }

        double IShape.CalculatePerimeter()
        {
            return Base + Height + Width;
        }
    }
}
