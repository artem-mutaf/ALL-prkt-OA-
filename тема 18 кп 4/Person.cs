using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_4
{/// <summary>
/// абстактный класс персона
/// </summary>
   abstract internal class Person
    {/// <summary>
    /// поле поисывающее фамилию ,имя 
    /// </summary>
        string name,surname;
        /// <summary>
        /// поле описывающее дату рождения
        /// </summary>
        DateTime dateB;
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="surname">surname</param>
        /// <param name="dateB">data</param>
        public Person (string name,string surname,DateTime dateB)
        {
          Name = name;
         Surname = surname;
           DateB=dateB;
        }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Person() { }
        /// <summary>
        /// свойтво для полей имя , фаимлия и дата родения
        /// </summary>
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public DateTime DateB { get => dateB; set => dateB = value; }
        /// <summary>
        /// метод Age для определения возраста 
        /// </summary>
        /// <returns></returns>
        
        public  int GetAge()
        {
            return DateTime.Now.Year - dateB.Year;
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
         public virtual void Print () 
        {
            Console.WriteLine($"Имя:{Name}\tФамилия:{Surname}\tДата:{DateB}");
        }


    }
}
