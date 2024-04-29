using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerechenPrkt
{
    class Rectangle
    {
        double side1;
        double side2;
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public Rectangle() { }

        public Rectangle(double side1,double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public double PerimeterCalculator()
        {
            return (Side1 + Side2) *2;
        }

        public double AreaCalculator()
        {
            return Side1 *Side2;
        }

        double Area { get; }
        double Perimeter { get; }

        //.
    }
}
