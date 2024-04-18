using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt3_4_
{
    abstract class Figure:IComparable<Figure>
    {
        public abstract double Square();
        public abstract double Perimeter();
        public int CompareTo(Figure other)
        {
            if (other == null)
                return 1;

            // Сравнение по площади
            return Square().CompareTo(other.Square());
        }

        public virtual void Info()
        {
            Console.WriteLine($"Фигура: {GetType().Name}");
            Console.WriteLine($"Площадь: {Square():f2}");
            Console.WriteLine($"Периметр: {Perimeter():f2}");
                
        }
    }
}
