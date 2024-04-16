using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 2
            MyClass myclass = new MyClass();
            IInterface i = myclass;
            Console.WriteLine($"Число ПИ = {i.Pi()}");
            Console.Write($"Целое число = {i.Whole()}\n");
            Console.Write($"Квадрат числа 2 = {i.Square()}\n");
            Console.Write($"Корень квадратный от 6 = {i.Sqrt():f2}");
            Console.ReadKey();
        }
    }
}
