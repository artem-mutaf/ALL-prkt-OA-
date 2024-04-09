using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt6
{
    class FreeSoftware : Software
    {
        public FreeSoftware() { }
        public FreeSoftware(string name,string manufacturer):base(name,manufacturer)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
        }
        public override void DisplayInfo()
        {
            WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}\n");
        }
        public override void IsUsableOnDate()
        {
            WriteLine(Name);
        }
    }
}
