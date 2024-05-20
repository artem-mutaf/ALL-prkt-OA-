using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Повторение2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите сторону а1 ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите сторону b1 ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите сторону c1 ");
            //int c = Convert.ToInt32(Console.ReadLine());
            Triangle<int> triangle1 = new Triangle<int>(1,2,3);
            triangle1.Print();
            Console.WriteLine($"Площадь = {triangle1.Area()}");
            Triangle<double> triangle2 = new Triangle<double>(2.5,3.3,4.2);
            triangle2.Print();
            Console.WriteLine($"Площадь = {triangle2.Area()}");
            Triangle<uint> triangle3 = new Triangle<uint>(2u, 3u, 4u);
            triangle3.Print();
            Console.WriteLine($"Площадь = {triangle3.Area()}");

            Console.ReadKey();

        }
    }
}
