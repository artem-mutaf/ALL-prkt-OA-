using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt6_2_
{
    class Car:Vehicle
    {
        int power;
        public int Power { get => power; set => power = value; }
        public Car() { }
        public Car(int price,int maxspeed,DateTime release,int power):base(price,maxspeed,release)
        {
            this.power = power;
        }

        public static Car In()
        {
            try
            {
                Write("Введите цену автомобиля: ");
                int price = int.Parse(ReadLine());
                Write("Введите максимальную скорость автомобиля: ");
                int maxspeed = int.Parse(ReadLine());
                Write("Введите дату выпуска автомобиля: ");
                DateTime release = DateTime.Parse(ReadLine());
                Write("Введите мощность л.с. : ");
                int power = int.Parse(ReadLine());
                return new Car(price, maxspeed, release, power);
            }
            catch { return In(); }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Мощность автомобиля : {power} л.с.");
        }
    }
}
