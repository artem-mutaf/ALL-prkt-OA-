using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema18prkt3
{
    class Triangle:Figure
    {
        /// <summary>
        /// Скрытые внутренние поля
        /// </summary>
        int side1;
        int side2;
        int side3;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Triangle() { }

        /// <summary>
        /// Конструтор с параметрами
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        public Triangle(string name, int side1, int side2) : base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        /// <summary>
        /// Свойства к полям для доступа к ним
        /// </summary>
        public int Side1
        {
            get { return side1; }
            set { side1 = value; }
        }
        public int Side2
        {
            get { return side2; }
            set { side2 = value; }
        }
        public int Side3
        {
            get { return side3; }
            set { side3 = value; }
        }

        /// <summary>
        /// метод Area(), возвращающий площадь треугольника по его сторонам; 
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            int p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }


        /// <summary>
        /// метод Perimeter(), возвращающий периметр треугольника по его сторонам;
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }
        /// <summary>
        /// Вывод
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Размер 1 стороны: {side1}\nРазмер 2 стороны: {side2}\nРазмер 3 стороны: {side3}");
        }

    }
}
