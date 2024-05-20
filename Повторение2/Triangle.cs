using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Повторение2
{
    class Triangle<T>
    {
        private T a;
        private T b;
        private T c;

        public T A
        {
            set { value = a; }
            get { return a; }
        }
        public T B
        {
            set { value = b; }
            get { return b; }
        }
        public T C
        {
            set { value = c; }
            get { return c; }
        }
        public Triangle() { }
        public Triangle(T a,T b, T c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void Print()
        {
            Console.WriteLine($"A = {A}\nB = {B}\nC = {C}\n");
        }
        public double Area()
        {
            dynamic a1 = A;
            dynamic b1 = B;
            dynamic c1 = C;
            double p = (double)(a1 + b1 + c1) / 2;
            return Math.Sqrt((dynamic)p * ((dynamic)p - a1) * ((dynamic)p - b1) * ((dynamic)p - c1));
        }


    }
}
