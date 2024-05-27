using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1Перечисления
{
    //enum Month
    //{
    //    Январь,Февраль,Март,Апрель,Май,Июнь,Июль,Август,Сентябрь,Октябрь,Ноябрь,Декабрь
    //}
    //enum Days
    //{
    //    Понедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье
    //}
    
    class Program
    {
        static void Main(string[] args)
        {
            //Month i;
            //for (i = Month.Январь; i <= Month.Декабрь; i++)
            //    Console.WriteLine($"{(int)i} \t  {i}");

            //Days i;
            //for (i = Days.Понедельник; i <= Days.Воскресенье; i++)
            //    Console.WriteLine($"{i} имеет значение -  {(int)i}");
            //Oper operation = new Oper();
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(Oper.DoOperation(x, y,Oper.Operation.Add));
            Oper.DoOperation(x, y, Oper.Operation.Subtract);
            Oper.DoOperation(x, y, Oper.Operation.Multiply);
            Oper.DoOperation(x, y, Oper.Operation.Divide);




            Console.ReadKey();

        }
    }
}
