using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema18prkt5
{
    /// <summary>
    /// Создаем производный класс Продукт
    /// </summary>
    class Product:Shipment
    {
        public Product(string name,double price,DateTime manufacture,DateTime term):base(name,price,manufacture,term)
        {

        }
        
        public override void Print()
        {
            base.Print();
        }
    }
}
