using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Book<T>
    {
        //Создайте обобщенный класс который описывает книгу в классе должны быть внутренние поля названия книги, цены книги, кроме этого в классе должны быть свойства для этих полей, кроме этого должен быть метод задания названия книги, метод с универсальным=обобщенным параметром который задает цену книги, метод который выводит информацию о книге, в основном классе необходимо создать объекты обобщенного класса в которых цена книги будет целого типа а во втором методе строкового типа.

        string name;
        T price;
        public string Name { get; set; }
        public T Price { get; set; }
        public Book() { }
        public Book(string name, T price) { Name = name; Price = price; }

        public Book<int> NameOfBookInt(int price)
        {
            Console.WriteLine("Введите название книги: ");
            string name = Console.ReadLine();
            
            return new Book<int>(name, price);

        }

        public Book<string> NameOfBookStr(string price)
        {
            Console.WriteLine("Введите название книги");
            string name = Console.ReadLine();
            //string price = "17 in string";

            return new Book<string>(name, price);

        }

        public void Info()
        {
            Console.WriteLine($"Name: {Name}\nPrice: {Price}");
        }


        




    }
}
