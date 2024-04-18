using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt3_4_
{
    class Circle:Figure
    {
        public double Radius { get; set; }
        public override double Square()
        {
            return Math.PI * Radius * Radius;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
