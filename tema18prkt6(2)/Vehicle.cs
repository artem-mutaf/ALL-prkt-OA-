using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt6_2_
{
    abstract class Vehicle
    {
        int price;
        int maxspeed;
        DateTime release;

        public int Price { get => price; set => price = value; }
        public int Maxspeed { get => maxspeed; set => maxspeed = value; }
        public DateTime Release { get => release; set => release = value; }
        public Vehicle() { }
        public Vehicle(int price,int maxspeed,DateTime release)
        {
            this.price = price;
            this.maxspeed = maxspeed;
            this.release = release;
        }

        public virtual void Print()
        {
            WriteLine($"Цена: {price}\n Макс скорость: {maxspeed}\nДата выпуска: {release}");
        }


    }
}
