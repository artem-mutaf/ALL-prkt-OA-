using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Повторение1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> point1 = new Point<int>(5, 3);
            Point<double> point2 = new Point<double>(5.3, 4.6);
            Point<uint> point3 = new Point<uint>(34u, 54u);

            point1.Info();
            point2.Info();
            point3.Info();

            Console.ReadKey();

        }
    }
}
