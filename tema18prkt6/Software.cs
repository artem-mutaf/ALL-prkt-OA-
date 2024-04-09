using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt6
{
    abstract class Software
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }

        public Software() { }
        public Software(string manufacturer,string name) 
        {
            this.Manufacturer = manufacturer;
            this.Name = name; 
        }

        public abstract void DisplayInfo();

        public abstract void IsUsableOnDate();

    }
}
