using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt4_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем коллекцию
            List<TravelAgency> travelAgency = new List<TravelAgency>();
            travelAgency.Add(new TravelAgency("Coral Travel",1995,"7707255341",5));//39610540
            travelAgency.Add(new TravelAgency("TezTour", 1994, "7709297570", 30));
            travelAgency.Add(new TravelAgency("PegasTouristik", 1994, "7714126996", 52));

            //Для заданной фирмы находим ИНН и прибыль в базе
            Console.WriteLine("Введите название фирмы: ");
            string nname = Console.ReadLine();
            foreach(var name in travelAgency)
            {
                if(name.Name==nname)
                {
                    Console.WriteLine($"ИНН данной фирмы: {name.Id}\nПрибыль: {name.Profit}$");
                }
                
            }

            //Находим сумму прибыли всех фирм
            double sumprofit = 0;
            foreach(var profit in travelAgency)
            {
                sumprofit += profit.Profit;
                
            }
            Console.WriteLine($"Суммарная прибыль: {sumprofit}$");

            travelAgency.Sort();

            Console.WriteLine($"Назвние фирмы которая получила наибольшую прибыль: {travelAgency[travelAgency.Count-1].Name}\n" +
                $"Размер прибыли: {travelAgency[travelAgency.Count - 1].Profit}$");
  


            Console.ReadKey();


        }
    }
}
