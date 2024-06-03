using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._06abstr
{
    class ExcelentPupil:Pupil
    {
        public ExcelentPupil(string fam) : base(fam) { }
        public override void Study()
        {
            Console.WriteLine($"{Fam} учится отлично!");
        }
        public override void Read()
        {
            Console.WriteLine($"{Fam} читает очень быстро!");
        }
        public override void Write()
        {
            Console.WriteLine($"{Fam} пишет без ошибок!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Fam} отдыхает, играя в шахматы!\n");
        }

    }
}
