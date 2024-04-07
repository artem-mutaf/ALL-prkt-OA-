using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema18prkt5
{
    abstract class Goods
    {
        /// <summary>
        /// Создаем переменные со свойствами
        /// </summary>
        public string Name { get; set; }
        public int Price { get; set; }
        /// <summary>
        /// Конструктор по умолчанию и с параметрами
        /// </summary>
        public Goods() { }
        public Goods(string name,int price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// Метод который будет выводить соответствует ли товар своему сроку годности
        /// </summary>
        /// <returns></returns>
        public abstract string DeadkineExpirationDate();
        /// <summary>
        /// Метод вывода
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Название: {Name}\nЦена: {Price}";
        }


    }
}
