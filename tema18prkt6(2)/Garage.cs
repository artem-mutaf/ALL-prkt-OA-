using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt6_2_
{
    class Garage
    {
        List<Vehicle> vehicle = new List<Vehicle>();

        bool flag = true;

        public void Print2()
        {
            while(flag)
            {
                WriteLine("\t1.Добавить в список велосипед");
                WriteLine("\t2.Добавить в список машину");
                WriteLine("\t3.Добавить в списко грузовики");
                WriteLine("\t4.Вывести все велосипеды в списке");
                WriteLine("\t5.Вывести все машины из списка");
                WriteLine("\t6.Вывести все грузовики из списка");
                WriteLine("\t7.Выход");
                Write("Выберите нужное вам действие: ");
                string stt = ReadLine();
                switch(stt)
                {
                    case "1":
                        Bicycle bicycle = new Bicycle();
                        vehicle.Add(Bicycle.In());
                        break;
                    case "2":
                        Car car = new Car();
                        vehicle.Add(Car.In());
                        break;
                    case "3":
                        Lorry lorry = new Lorry();
                        vehicle.Add(Lorry.In());
                        break;
                    case "4":
                        Bicycle bic = new Bicycle();
                        bic.Print();
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                }
            }
        }
        
            
            
    }
}
