using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom4
{
    class Man:IInterface2,IInterface1
    {
        public void Print1()
        {
            Console.WriteLine("Говорит громко - Я люблю программирование!");
        }
        public void Print2()
        {
            Console.WriteLine("Думает - А С# больше всего");
            Console.WriteLine("Говорит нормально - Меньше люблю компьютерные игры");
        }
    }
}
