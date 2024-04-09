using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt6
{
    class CommercialSoftware:Software
    {
        public DateTime InstallationDate { get; set; }
        public int Price { get; set; }
        public int UsagePeriod { get; set; }

        public CommercialSoftware() { }
        public CommercialSoftware(string name,string manufacturer,int price,DateTime installationDate,int usagePeriod):base(name,manufacturer)
        {
            this.InstallationDate = installationDate;
            this.UsagePeriod = usagePeriod;
            this.Price = price;
        }
        public override void DisplayInfo()
        {
            WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}\nЦена: {Price}\n" +
                $"Дата установки: {InstallationDate}\nСрок использования: {UsagePeriod} дней\n");
        }
        public override void IsUsableOnDate()
        {
            if (InstallationDate <= DateTime.Now)
            {
                WriteLine(Name);
            }
            else { }
        }
    }
}
