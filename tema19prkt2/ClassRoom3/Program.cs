using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 3
            IInterface3 i = new DerivedClass();
            i.Method1();
            //DerivedClass dClass = new DerivedClass();
            //IInterface3
            i.Method2();
            i.Method3();
            Console.ReadKey();
        }
    }
}
