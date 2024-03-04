using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_4
{/// <summary>
/// наследуемый класс студент
/// </summary>
    internal class Student:Person
    {/// <summary>
    /// поле описывающее курс
    /// </summary>
        int curs;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Student() { }
        /// <summary>
        /// свойство для поля сурс
        /// </summary>
        public int Curs { get => curs; set => curs = value; }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="surname">surname</param>
        /// <param name="dateB"></param>
        /// <param name="faculty">faculty</param>
        /// <param name="curs">curs</param>
        public Student(string name, string surname, DateTime dateB, string faculty,int curs) : base(name, surname,dateB)
        {
            Curs= curs;
        }
        
        /// <summary>
        /// иетод для вывода информации  об объекте 
        /// </summary>
        /// <returns></returns>
        public static Student Init()
        {
            try
            {
                Console.Write("Имя:");
                string name = Console.ReadLine();
                Console.Write("Фамилия:");
                string surname = Console.ReadLine();
                Console.Write("Дата рождения:");
                DateTime dateB = DateTime.Parse(Console.ReadLine());
                Console.Write("Факультет:");
                string facult = Console.ReadLine();
                Console.Write("Курс:");
                int kurs = int.Parse(Console.ReadLine());
                return new Student(name, surname, dateB, facult, kurs);
            }
            catch { return Init(); }
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Курс:{curs} {GetAge()}");
        }
    }
}
