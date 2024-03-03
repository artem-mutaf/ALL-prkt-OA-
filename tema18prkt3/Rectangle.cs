using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt3
{
    class Rectangle:Figure
    {
        double side1;
        double side2;
        public double Side1
        {
            get { return side1; }
            set { side1 = value; }
        }
        public double Side2
        {
            get { return side2; }
            set { side2 = value; }
        }
        public Rectangle() { }
        public Rectangle(double side1,double side2,string name):base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public override double Area()
        {
            return side1*side2;
        }
        public override double Perimeter()
        {
            return (side1+side2)*2;
        }
        public override void Print()
        {
            
            WriteLine($"Имя фигуры: {Name}");
        }

    }
}
