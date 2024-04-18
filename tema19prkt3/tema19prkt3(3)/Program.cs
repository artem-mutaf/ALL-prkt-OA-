using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt3_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Всё отсортировано по цене\n");

            //Создаем коллекцию и вносим данные
            List<AutoShop> cars = new List<AutoShop>
            {
                new AutoShop(1, "Toyota Camry", 200, 22000, 12),
                new AutoShop(2, "Honda Civic", 235, 13000, 8),
                new AutoShop(3, "BMW M5 E60", 330, 40000, 20)
            };

            //Сортировка
            cars.Sort();

            //Вывод коллекции
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            Console.Read();
        }
    }
}
