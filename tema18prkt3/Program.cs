using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt3
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[]figures = new Figure[5];

            Dictionary<int, Figure> figure = new Dictionary<int, Figure>();

            int ii = 0;

            while(true)
            {
                WriteLine("Введите <1> чтобы добавить прямоугольник\nВведите <2> чтобы добавить треугольник\nВведите <3> чтобы добавить квадрат");
                Write("Вводите желаемый вариант: ");
                string voice = ReadLine();

                switch(voice)
                {
                    case "1":
                        Rectangle rectangle = new Rectangle();
                        WriteLine("Введите ширину прямоугольника: ");
                        rectangle.Side1 = double.Parse(ReadLine());
                        WriteLine("Введите высоту прямоугольника: ");
                        rectangle.Side2 = double.Parse(ReadLine());
                        WriteLine($"Площадь прямоугольника явл. : {rectangle.Area()}");
                        WriteLine($"периметр прямоугольника явл. : {rectangle.Perimeter()}");
                        figures[ii]=rectangle;
                        figure.Add(ii, rectangle);
                        ii++;
                        break;
                    case "2":
                        Triangle triangle = new Triangle();
                        WriteLine("Введите величину 1 стороны: ");
                        triangle.Side1 = int.Parse(ReadLine());
                        WriteLine("Введите величину 2 стороны: ");
                        triangle.Side2 = int.Parse(ReadLine());
                        WriteLine("Введите величину 3 стороны: ");
                        triangle.Side3 = int.Parse(ReadLine());
                        WriteLine($"Площадь треугольника явл. : {triangle.Area()}");
                        WriteLine($"периметр треугольника явл. : {triangle.Perimeter()}");
                        figures[ii] = triangle;
                        figure.Add(ii, triangle);
                        ii++;
                        break;
                    case "3":
                        Square square = new Square();
                        WriteLine("Введите величину 1 стороны: ");
                        square.Side1 = int.Parse(ReadLine());
                        WriteLine("Введите величину 2 стороны");
                        square.Side2 = int.Parse(ReadLine());
                        WriteLine($"Площадь треугольника явл. : {square.Area()}");
                        WriteLine($"периметр треугольника явл. : {square.Perimeter()}");
                        figures[ii] = square;
                        figure.Add(ii, square);
                        ii++;
                        break;
                }
            }
            ReadKey();
        }
    }
}
