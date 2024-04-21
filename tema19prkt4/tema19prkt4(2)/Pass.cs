using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt4_2_
{
    abstract class Pass
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Faculty { get; set; }

        public Pass(string lastName, string firstName, string patronymic, string faculty)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Faculty = faculty;
        }

        // Метод для вывода информации о пропуске
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ФИО: {LastName} {FirstName} {Patronymic}");
            Console.WriteLine($"Факультет: {Faculty}");
        }
    }
}
