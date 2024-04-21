using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt4_2_
{
    class TeacherPass : Pass, IPass
    {
        public string Department { get; set; }

        public TeacherPass(string lastName, string firstName, string patronymic, string faculty, string department)
            : base(lastName, firstName, patronymic, faculty)
        {
            Department = department;
        }

        // Реализация методов интерфейса IPass
        public void UpdatePass()
        {
            Console.WriteLine("Пропуск преподавателя обновлен.");
        }

        public void CancelPass()
        {
            Console.WriteLine("Пропуск преподавателя аннулирован.");
        }

        // Переопределение метода DisplayInfo для преподавателя
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Кафедра: {Department}");
        }
    }
}
