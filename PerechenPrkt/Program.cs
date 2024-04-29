using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerechenPrkt
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите длину 1 стороны: ");
            rectangle.Side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину 2 стороны: ");
            rectangle.Side2 = double.Parse(Console.ReadLine());


            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine("\tИнфо:\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tПериметр прямоугольника = "+"<"+rectangle.PerimeterCalculator()+">");
            Console.WriteLine("\tПлощадь прямоугольника = " + "<"+rectangle.AreaCalculator()+">"+"\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нажмите любую клавишу для закрытия консоли...");






























































            Console.ReadKey();
        }
    }
}
