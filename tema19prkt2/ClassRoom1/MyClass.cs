using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom1
{
    class MyClass:IInterface
    {
        public double Pi()
        {
            return 3.14;
        }
        public int Whole()
        {
            return 55;
        }
        public double Square()
        {
            return Math.Pow(2,2);
        }
        public double Sqrt()
        {
            return Math.Sqrt(33);
        }
    }
}
