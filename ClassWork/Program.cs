using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person<int, string> tom = new Person<int, string>(546, "qwerty", "Tom");
            //Console.WriteLine(tom.Id);  // 546
            //Console.WriteLine(tom.Password);// qwerty

            //Person<int> tom = new Person<int>(546, "Tom");
            //Person<int>.code = 1234;

            //Person<string> bob = new Person<string>("abc", "Bob");
            //Person<string>.code = "meta";

            //Console.WriteLine(Person<int>.code);       // 1234
            //Console.WriteLine(Person<string>.code);  //meta

            //int x = 7;
            //int y = 25;
            //Swap<int>(ref x, ref y); // или так Swap(ref x, ref y);
            //Console.WriteLine($"x={x}    y={y}");   // x=25   y=7

            //string s1 = "hello";
            //string s2 = "bye";
            //Swap<string>(ref s1, ref s2); // или так Swap(ref s1, ref s2);
            //Console.WriteLine($"s1={s1}    s2={s2}"); // s1=bye   s2=hello

            //void Swap<T>(ref T x, ref T y)
            //{
            //    T temp = x;
            //    x = y;
            //    y = temp;
            //}


            //Book<string> book = new Book<string>("Book1","456 int string");
            //Console.WriteLine(book.Name);
            //Console.WriteLine(book.Price);
            

            //Console.WriteLine(book.NameOfBookInt(459));
            //Console.WriteLine(book.NameOfBookStr("469 in string"));
            //book.Info();


            Console.ReadLine();
        }
    }
}
