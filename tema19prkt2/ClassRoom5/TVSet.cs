using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom5
{
    class TVSet:ISwitchhable
    {
        /// <summary>
        /// Методы выкл и вкл
        /// </summary>
        public void On()
        {
            Console.WriteLine("Телевизор включен");
        }
        public void Off()
        {
            Console.WriteLine("Телевизор выключен");
        }
    }
}
