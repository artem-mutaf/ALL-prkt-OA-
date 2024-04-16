using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom5
{
    class Pc:ISwitchhable
    {
        /// <summary>
        /// Методы выкл и вкл
        /// </summary>
        public void On()
        {
            Console.WriteLine("Ваш персональный компьютер включен");
        }
        public void Off()
        {
            Console.WriteLine("Ваш персональный компьютер выключен");
        }
    }
}
