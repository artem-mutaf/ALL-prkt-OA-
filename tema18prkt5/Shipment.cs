using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt5
{
    /// <summary>
    /// Создаем абстрактный класс Товар
    /// </summary>
    abstract class Shipment
    {
        string name;
        double price;
        DateTime manufacture;
        DateTime term;
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public DateTime Manufacture { get => manufacture; set => manufacture = value; }
        public DateTime Term { get => term; set => term = value; }
        public Shipment() { }
        public Shipment(string name,double price,DateTime manufacture,DateTime term)
        {
            this.name = name;
            this.price = price;
            this.manufacture = manufacture;
            this.term = term;
        }
        public void GetTerm()
        {
            if(term.Year > DateTime.Now.Year)
            {
                WriteLine($"Продукт не просрочен");
            }
            else
            {
                WriteLine("Продукт просрочен");
            }
        }
        public virtual void Print()
        {
            WriteLine($"Наименование товара: {name}\nЦена товара: {price}\n Дата производства: {manufacture}" +
                $"\nСрок годности до: {term} года");
        }

    }
}
