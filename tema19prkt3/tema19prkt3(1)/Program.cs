using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> arrBooks = new List<Book>(); // создаем List
                                                    // заполняем Библиотеку книг
            arrBooks.Add(new Book() { Name = "Властелин Колец", Price = 200 });
            arrBooks.Add(new Book() { Name = "Три мушкетера", Price = 300 });
            arrBooks.Add(new Book() { Name = "Гарри Поттер", Price = 400 });
            // сортируем по Названию книги
            arrBooks.Sort();
            // показываем результат на экран
            for (int i = 0; i < arrBooks.Count; i++)
            {
                Book item = arrBooks[i];
                Console.WriteLine("Название: {0}, Цена: {1}", item.Name, item.Price);
            }
            Console.Read();

        }
    }
}
