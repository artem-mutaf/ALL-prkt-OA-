using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_4
{/// <summary>
/// наследуемый класс
/// </summary>
    internal class Teacher:Person
    {/// <summary>
    /// поле описывающее стаж
    /// </summary>
        int experience;
        /// <summary>
        /// поле описывающее должность
        /// </summary>
        string position;
        /// <summary>
        /// свойство для полей
        /// </summary>

        public int Experience { get => experience; set => experience = value; }
        public string Position { get => position; set => position = value; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Teacher() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="surname">surname</param>
        /// <param name="dateB">dateB</param>
        /// <param name="faculty">faculty</param>
        /// <param name="experience">experience</param>
        /// <param name="position">position</param>

        public Teacher(string name, string surname, DateTime dateB, string faculty, int experience, string position) : base(name, surname, dateB)
        {
            Experience = experience;
            Position = position;
        }

        /// <summary>
        /// метод для вывода информации об объекте 
        /// </summary>
        /// <returns></returns>
        public static Teacher Init()
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
                string faculty = Console.ReadLine();
                Console.Write("Должность:");
                string position = Console.ReadLine();
                Console.Write("Стаж:");
                int experience = int.Parse(Console.ReadLine());
                return new Teacher(name, surname, dateB, faculty,  experience, position);
            }
            catch { return Init(); }
        }/// <summary>
        /// иетод для вывода инфлормации
        /// </summary>

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Стаж:{experience}\nДолжность:{position} {GetAge()}");
        }
    }
}
