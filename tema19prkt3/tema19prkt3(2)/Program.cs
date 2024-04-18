using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> arrPersons = new List<Person>(); // создаем List
                                                    // заполняем список
            arrPersons.Add(new Person() { Name = "Мутаф Артём", Age = 17 });
            arrPersons.Add(new Person() { Name = "Абабий Илья", Age = 17 });
            arrPersons.Add(new Person() { Name = "Ботнарь Артем", Age = 17 });
            // сортируем по Имени человека
            arrPersons.Sort();
            // показываем результат на экран
            for (int i = 0; i < arrPersons.Count; i++)
            {
                Person item = arrPersons[i];
                Console.WriteLine("Название: {0}, Цена: {1}", item.Name, item.Age);
            }
            Console.Read();
        }
    }
}
