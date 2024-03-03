using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema18prkt3
{
    /// <summary>
    /// Создаем абстрактный класс
    /// </summary>
    abstract class Figure
    {
        /// <summary>
        /// Скрытое поле имени переменной
        /// </summary>
        protected string name;

        /// <summary>
        /// Свойста к полю
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Конструктор с одним параметром инициализирующий поле Name
        /// </summary>
        /// <param name="name"></param>
        public Figure(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Figure() { }

        /// <summary>
        /// Три метода для получения (Площади,Периметра) и метод вывода
        /// </summary>
        /// <returns></returns>
        public abstract double Area();
        public abstract double Perimeter();
        public abstract void Print();


    }
}
