using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._5zad
{
    class Tovaar
    {
        string name;
        double price;
        int kvo;
        public string Name { get; set; }
        public double Price
        {
            get { return price; }

            set
            {
                if (value < 1 || value > 20)
                    Console.WriteLine("Цена должна быть в диапозоне от 1 до 20");
                else
                    price = value;
            } 
        }
        public int Kvo 
        { 
            get { return kvo; }

            set
            {
                if (value < 1 || value > 10)
                    Console.WriteLine("Кол-во должно быть в диапозоне от 0 до 10");
                else
                    kvo = value;
            } 
        }

        public Tovaar() { }

        public Tovaar(string name,double price,int kvo)
        {
            Name = name;
            Price = price;
            Kvo = kvo;
        }

        public static Tovaar Input()
        {
            Console.Write("Введите название товара: ");
            string name = Console.ReadLine();
            Console.Write("Введите цену товара: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Введите кол-во товара: ");
            int kvo = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Название: {name}, Цена: {price}, Кол-во товара: {kvo}\n");

            return new Tovaar(name,price,kvo);
        }
        public double Sum()
        {
            return Price*Kvo;
        }


    }
}
