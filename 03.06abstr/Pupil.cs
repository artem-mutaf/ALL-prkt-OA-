using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._06abstr
{
    abstract class Pupil
    {
        string fam;
        public string Fam { get; set; }

        public Pupil(string fam) { Fam = fam; }

        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();



    }
}
