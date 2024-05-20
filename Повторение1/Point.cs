using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Повторение1
{
    class Point <T>
    {
        //Внутренние поля
        T x;
        T y;
        //Свойства
        public T X { get; }
        public T Y { get; }
        //Конструкторы
        public Point() { }
        public Point(T x,T y) 
        {
            X = x;
            Y = y;
        }

        public void Info()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Значение x = {X} , Значение y = {Y}");
        }

    }
}
