using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt4_2_
{
    class StudentPass:Pass,IPass
    {
        public int EnrollmentYear { get; set; }

        public StudentPass(string lastName, string firstName, string patronymic, string faculty, int enrollmentYear)
            : base(lastName, firstName, patronymic, faculty)
        {
            EnrollmentYear = enrollmentYear;
        }

        // Реализация методов интерфейса IPass
        public void UpdatePass()
        {
            Console.WriteLine("Пропуск студента обновлен.");
        }

        public void CancelPass()
        {
            Console.WriteLine("Пропуск студента аннулирован.");
        }

        // Переопределение метода DisplayInfo для студента
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Год поступления: {EnrollmentYear}");
        }
    }
}
