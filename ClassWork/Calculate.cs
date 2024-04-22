using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Calculate<Tp>
    {
        //Необходимо создать обобщенный класс калькулятора с методом с двумя параметрами, основные действия 4 арифметических действия, в классе программ создать первый объект у которого 2 параметра целых, след объект 1 параметр целый второй вещественный,  и ещё 1 у которого 1 целый 2 строковый

        public Tp A {  get; set; }
        public Tp B { get; set; }

        public Calculate(Tp a, Tp b) {  A = a; B = b; }
        public Calculate<int> GetCalculate()
        {
            return A + B;
        }
    }
}
