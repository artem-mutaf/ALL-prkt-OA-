using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Software> software = new List<Software>();

            software.Add(new FreeSoftware("Notepad++","Notepad++ Team"));
            software.Add(new TrialSoftware("Adobe Photoshop", "Adobe", 30, new DateTime(2024,02,14,18,00,16)));
            software.Add(new CommercialSoftware("Microsoft Office", "Microsoft", 1000, new DateTime(2023, 12, 26, 18, 00, 16),365));

            foreach(var elem in software)
            {
                elem.DisplayInfo();
                Write("Программное обеспечение, которое допусимо использовать на текущую дату: \n");
                elem.IsUsableOnDate();
            }

            
            

            ReadLine();
        }
    }
}
