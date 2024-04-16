using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom6
{
    class Aa:A,Interface2
    {
        public Aa(int a,int b) : base(a, b) { }
        public void Pow()
        {
            Console.WriteLine("obj2:\n");
            Console.WriteLine($"Переменная: {X}\nПеременная: {B}");
            Console.WriteLine("Квадратное уравнение: \n");
            Console.WriteLine("а в квадарте =" + Math.Pow(X, 2));
            Console.WriteLine("b в квадрате ="+Math.Pow(B, 2)+"\n");
        }
        public void Sqrt()
        {
            Console.WriteLine("Корень квадратный: \n");
            Console.WriteLine($"корень квадратный от а ={Math.Sqrt(X):f2}");
            Console.WriteLine($"корень квадратный от b ={Math.Sqrt(B):f2}");
        }
    }
}
