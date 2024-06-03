using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._06abstr
{
    class ClassRoom
    {
        public ClassRoom() { }
        public ClassRoom(Pupil pupil) { }
        public ClassRoom(Pupil pupil1,Pupil pupil2,Pupil pupil3) { }
        //public ClassRoom(GoodPupil pupil2) { }
        //public ClassRoom(BadPupil pupil3) { }

        public void Print(Pupil pupil)
        {
            Console.WriteLine($"Ученик {pupil.Fam}:");
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
        }
    }
}
