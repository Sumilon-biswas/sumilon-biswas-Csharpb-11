using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;


namespace Task3
{
    public class Circle : IShape
    {
        public double Redius { get; set; }

        public Circle(double x)
        {
            Redius = x;
        }

        double IShape.CalculateArea()
        {
            return 3.1416 * Redius * Redius;
        }

        double IShape.CalculatePerimeter()
        {
            return 2 * 3.1416 * Redius;
        }
    }
}
