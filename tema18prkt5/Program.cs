using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema18prkt5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Goods> ll = new List<Goods>();

            ll.Add(new Product("Молоко", 120, new DateTime(2024, 02, 14), new DateTime(2024, 02, 16)));
            ll.Add(new Party("Яблоки", 220, 302, new DateTime(2024, 02, 14), new DateTime(2024, 02, 16)));
            ll.Add(new Kit("Подарочные наборы", 600, "\n\t- Шоколад\n\t- Печенье"));

            foreach(var it in ll)
            {
                Console.WriteLine(it.ToString());
                Console.WriteLine(it.DeadkineExpirationDate());
            }
            

            Console.ReadLine();
                
        }
    }
}
