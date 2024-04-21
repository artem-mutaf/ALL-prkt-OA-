using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt4_2_
{
    class BuilderPass : Pass, IPass
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public BuilderPass(string lastName, string firstName, string patronymic, string faculty, DateTime startDate, DateTime endDate)
            : base(lastName, firstName, patronymic, faculty)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        // Реализация методов интерфейса IPass
        public void UpdatePass()
        {
            Console.WriteLine("Пропуск строителя обновлен.");
        }

        public void CancelPass()
        {
            Console.WriteLine("Пропуск строителя аннулирован.");
        }

        // Переопределение метода DisplayInfo для строителя
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Дата начала работ: {StartDate}");
            Console.WriteLine($"Дата окончания работ: {EndDate}");
        }
    }
}
