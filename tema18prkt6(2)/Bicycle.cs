using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt6_2_
{
    class Bicycle : Vehicle
    {
        int maxPassengers;
        public int MaxPassengers { get => maxPassengers; set => maxPassengers = value; }
        public Bicycle() { }
        public Bicycle(int price,int maxspeed,DateTime release,int maxPassengers):base(price,maxspeed,release)
        {
            this.maxPassengers = maxPassengers;
        }

        public static Bicycle In()
        {
            try
            {
                Write("Введите цену велосипеда: ");
                int price = int.Parse(ReadLine());
                Write("Введите максимальную скорость велосипеда: ");
                int maxspeed = int.Parse(ReadLine());
                Write("Введите дату выпуска велосипеда: ");
                DateTime release = DateTime.Parse(ReadLine());
                Write("Введите кол-во пассажиров: ");
                int maxPassengers = int.Parse(ReadLine());
                return new Bicycle(price, maxspeed, release, maxPassengers); 
            }
            catch { return In(); }
        }

        public override void Print()
        {
            base.Print();
            WriteLine($"Кол-во пассажиров: {maxPassengers}");
        }

    }
}
