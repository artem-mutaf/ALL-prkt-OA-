using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass();
            d.Method();
            IInterface i = new DerivedClass();
            i.Method();
            
            Console.ReadKey();
        }
    }
}
