using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите кого добавить:");
                string status = Console.ReadLine();
                switch (status.ToLower())
                {
                    case "e": Enrollee enrollee = new Enrollee(); person.Add(Enrollee.Init()); break;
                    case "s": Student student = new Student(); person.Add(Student.Init()); break;
                    case "t": Teacher teacher = new Teacher(); person.Add(Teacher.Init()); break;
                    default: Console.Clear(); flag = false; break;
                }
            }
            foreach (var elem in person)
            {
                elem.Print();
            }
            Console.WriteLine("Введите нижнюю границу диапозона: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу диапозона: ");
            int a = int.Parse(Console.ReadLine());
            foreach (var elem in person)
            {
                
                if (elem.GetAge() > b && elem.GetAge() < a)
                {
                     elem.Print();
                }
            }
            Console.ReadLine();
        }

    }
}
