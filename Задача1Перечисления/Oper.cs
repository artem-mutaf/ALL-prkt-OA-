using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1Перечисления
{
    class Oper
    {
        //public Oper() { }
        public static double DoOperation(double x, double y, Operation op)
        {
            double result = 0;
            //{
            //    Operation.Add => x + y,
            //    Operation.Subtract => x - y,
            //    Operation.Multiply => x * y,
            //    Operation.Divide => x / y
            //};
            switch(op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
                default:
                    Console.WriteLine("Вы выбрали не правильный вариант");
                    break;
            }
            return result;
        }
        public enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
    }
}
