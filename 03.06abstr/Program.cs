using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._06abstr
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil excelent = new ExcelentPupil("Петров");
            GoodPupil good = new GoodPupil("Иванов");
            BadPupil bad = new BadPupil("Сидоров");
            ClassRoom classRoom = new ClassRoom(excelent,good,bad);
            classRoom.Print(excelent);
            classRoom.Print(good);
            classRoom.Print(bad);

            Console.ReadKey();
            
        }
    }
}
