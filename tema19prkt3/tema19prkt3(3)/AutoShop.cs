using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt3_3_
{
    class AutoShop:IComparable<AutoShop>
    {
        /// <summary>
        /// Создаем свойства
        /// </summary>
        public int Id { get; set; }
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        /// <summary>
        /// Создаем конструктор и инициализируем свойства
        /// </summary>
        /// <param name="id"></param>
        /// <param name="brand"></param>
        /// <param name="maxSpeed"></param>
        /// <param name="price"></param>
        /// <param name="discount"></param>
        public AutoShop(int id, string brand, int maxSpeed, double price,double discount)
        {
            Id = id;
            Brand = brand;
            MaxSpeed = maxSpeed;
            Price = price;
            Discount = discount;
        }
        /// <summary>
        /// Метод с сортировкой цены
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(AutoShop other)
        {
            if (other == null)
                return 1;

            // Применяем скидку к цене
            double discountedPriceThis = Price * (1 - Discount / 100);
            double discountedPriceOther = other.Price * (1 - other.Discount / 100);

            // Сравниваем по цене после скидки
            return discountedPriceThis.CompareTo(discountedPriceOther);

            
        }
        /// <summary>
        /// Метод для вывода всё информации отсортированной по цене
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Идентификатор: {Id}, Марка: {Brand}, Максимальная скорость: {MaxSpeed} km/h\nЦена без учета скидки: {Price}$, " +
                $"Цена по скидке {Discount}%: {Price * (1 - Discount / 100)}$\n";
        }

    }
}
