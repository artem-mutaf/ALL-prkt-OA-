using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем список
            List<ISwitchhable> ll = new List<ISwitchhable>();
            ll.Add(new Pc());
            ll.Add(new TVSet());
            //Метод вывода информации
            foreach(var dev in ll)
            {
                dev.On();
                dev.Off();
            }

            Console.ReadLine();
        }
    }
}
