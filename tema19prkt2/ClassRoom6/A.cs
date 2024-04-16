using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom6
{
    class A:Interface1
    {
        public int X { get; set; }
        public int B { get; set; }

        public A(int x,int b) { X = x;B = b; }
        
        public void Arithmetic()
        {
            Console.WriteLine("obj1:\n");
            int g = X + B, j = X / B, h = X * B, f = X - B;
            Console.WriteLine($"Переменная a: {X}\nПеременная b: {B}\n");
            Console.WriteLine($"{X} + {B} = {g}\n" +
                $"{X} - {B} = {f}\n{X} * {B} = {h}\n{X} / {B} = {j}\n");
        }
    }
}
