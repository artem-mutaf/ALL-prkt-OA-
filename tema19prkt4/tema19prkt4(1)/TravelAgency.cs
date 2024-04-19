using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt4_1_
{
    class TravelAgency:IComparable<TravelAgency>
    {
        /// <summary>
        /// Создаем поля
        /// </summary>
        string name;
        int year;
        string id;
        double profit; 
        /// <summary>
        /// Делаем поля доступными создаем им свойства
        /// </summary>
        public string Name { get; set; }
        public int Year { get; set; }
        public string Id { get; set; }
        public double Profit { get; set; }
        /// <summary>
        /// Конструктор по умолчанию и после него уже с параметрами
        /// </summary>
        public TravelAgency() { }
        public TravelAgency(string name, int year, string id, double profit)
        {
            Name = name;
            Year = year;
            Id = id;
            Profit = profit;
        }

        /// <summary>
        /// Делаем метод вывода
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Название: {Name}\nГода создания: {Year}\n" +
                $"ИНН фирмы: {Id}\nПрибыль фирмы: {Profit}$\n");
            
        }

        public int CompareTo(TravelAgency travel)
        {
            return Profit.CompareTo(travel.Profit);
        }

    }
}
