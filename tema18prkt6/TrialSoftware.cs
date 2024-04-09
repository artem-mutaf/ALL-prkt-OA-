using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt6
{
    class TrialSoftware:Software
    {
        public int FreeUsagePeriod { get; set; }
        public DateTime InstallationDate { get; set; }

        public TrialSoftware() { }
        public TrialSoftware(string name,string manufacturer, int freeUsagePeriod,DateTime installationDate):base(manufacturer,name)
        {
            this.FreeUsagePeriod = freeUsagePeriod;
            this.InstallationDate = installationDate;
        }

        public override void DisplayInfo()
        {
            WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}\n" +
                $"Дата установки: {InstallationDate}\nСрок бесплатного использования: {FreeUsagePeriod} дней\n");
        }
        public override void IsUsableOnDate()
        {
            if(InstallationDate<=DateTime.Now)
            {
                WriteLine(Name);
            }
            else { }
        }
    }
}
