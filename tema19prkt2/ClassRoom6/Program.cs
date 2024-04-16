using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom6
{
    class Program
    {
        static void Main(string[] args)
        {
            A l = new A(52, 13);
            Aa n = new Aa(53, 42);

            l.Arithmetic();
            n.Pow();
            n.Sqrt();
            Console.ReadLine();
        }
    }
}
