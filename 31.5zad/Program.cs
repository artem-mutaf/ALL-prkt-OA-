using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._5zad
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tovar tour = new Tovar();
            //tour.TourCalc();
            //tour.TourCalc("Турция");
            //tour.TourCalc("Германия",5000);

            Tovaar tovar = new Tovaar("Яблоки",17,6);
            Tovaar tovar1 = new Tovaar("Бананы",14,4);
            Console.WriteLine($"Стоимость всех яблок: {tovar.Sum()}");
            Console.WriteLine($"Стоимость всех бананов: { tovar1.Sum()}");
            Console.WriteLine($"Стоимость всех бананов и яблок: {tovar.Sum() + tovar1.Sum()}"); ;

            Console.ReadKey();
        }
    }
}
