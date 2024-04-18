using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt3_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[]
            {
                new Rectangle{Width = 5,Height = 3},
                new Triangle{Side1 = 3,Side2=4,Side3 = 5 },
                new Circle{Radius=4}
            };

            foreach (var figure in figures)
            {
                figure.Info();
                Console.WriteLine();
            }

            Array.Sort(figures);
            

            Console.WriteLine("Отсортировано по площади:\n");

            foreach (var figure in figures)
            {
                figure.Info();
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
