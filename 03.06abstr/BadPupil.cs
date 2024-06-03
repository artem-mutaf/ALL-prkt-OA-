using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._06abstr
{
    class BadPupil:Pupil
    {
        public BadPupil(string fam) : base(fam) { }
        public override void Study()
        {
            Console.WriteLine($"{Fam} учится плохо!");
        }
        public override void Read()
        {
            Console.WriteLine($"{Fam} читает очень медленно!");
        }
        public override void Write()
        {
            Console.WriteLine($"{Fam} пишет с большим количеством ошибок!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Fam} отдыхает, играя в компьютерные игры!");
        }
    }
}
