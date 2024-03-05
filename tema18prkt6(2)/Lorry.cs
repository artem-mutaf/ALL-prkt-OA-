using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt6_2_
{
    class Lorry:Vehicle
    {
        int maxCapacity;
        public int MaxCapacity { get => maxCapacity; set => maxCapacity = value; }
        public Lorry() { }
        public Lorry(int price,int maxspeed,DateTime release,int maxCapacity):base(price,maxspeed,release)
        {
            this.maxCapacity = maxCapacity;
        }

        public static Lorry In()
        {
            try
            {
                Write("Введите цену грузовика: ");
                int price = int.Parse(ReadLine());
                Write("Введите максимальную скорость грузовика: ");
                int maxspeed = int.Parse(ReadLine());
                Write("Введите дату выпуска грузовика: ");
                DateTime release = DateTime.Parse(ReadLine());
                Write("Введите максимальную ёмкость грузовика : ");
                int maxCapacity = int.Parse(ReadLine());
                return new Lorry(price, maxspeed, release, maxCapacity);
            }
            catch { return In(); }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Максимальная ёмкость грузовика : {maxCapacity}");
        }

    }
}
