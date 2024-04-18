using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt3_4_
{
    class Rectangle:Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Square()
        {
            return Width * Height;
        }
        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
