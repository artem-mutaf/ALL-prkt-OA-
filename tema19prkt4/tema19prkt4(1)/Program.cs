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
            travelAgency.Add(new TravelAgency("Coral Travel",1995,"7707255341",0));
            travelAgency.Add(new TravelAgency("TezTour", 1994, "7709297570", 30));
            travelAgency.Add(new TravelAgency("PegasTouristik", 1994, "7714126996", 52));


            Console.WriteLine("Информация о всех фирмах на базе\n");
            foreach(var info in travelAgency)
            {
                info.Info();
            }

            //Для заданной фирмы находим ИНН и прибыль в базе
            Console.Write("Введите название фирмы: ");
            string nname = Console.ReadLine();
            foreach(var name in travelAgency)
            {
                
                if(name.Name==nname)
                {
                    Console.WriteLine($"ИНН данной фирмы: {name.Id}\nПрибыль: {name.Profit}$\n");
                }
                
            }

            //Находим сумму прибыли всех фирм
            double sumprofit = 0;
            foreach(var profit in travelAgency)
            {
                sumprofit += profit.Profit;
                
            }
            Console.WriteLine($"Суммарная прибыль: {sumprofit}$\n");

            
            //Выполняем сортировку и смотрим какая фирма получила наибольшую прибыль
            travelAgency.Sort();

            Console.WriteLine($"Название фирмы которая получила наибольшую прибыль: {travelAgency[travelAgency.Count-1].Name}\n" +
                $"Размер прибыли: {travelAgency[travelAgency.Count - 1].Profit}$\n");
             
            //Удаление обанкротившейся фирмы со списка
            string bankruptCompanyName = "Coral Travel";
            TravelAgency bankruptAgency = travelAgency.Find(x => x.Name == bankruptCompanyName);
            if (bankruptAgency != null)
            {
                travelAgency.Remove(bankruptAgency);
                Console.WriteLine($"Информация об обанкротившейся фирме {bankruptCompanyName} удалена\n");
            }
            else
            {
                Console.WriteLine($"Фирма {bankruptCompanyName} не найдена\n");
            }

            //Добавляем информацию о новой фирме
            TravelAgency agency = new TravelAgency("NewFirm", 2020, "1357924680", 32);
            travelAgency.Add(agency);
            Console.WriteLine($"Информация о новой фирме {agency.Name} добалена");
            
            


            Console.ReadKey();


        }
    }
}
