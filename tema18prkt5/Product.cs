using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema18prkt5
{
    class Product:Goods 
    {
        public DateTime ExpirationDate { get; set; }
        public DateTime ProductionDate { get; set; }

        
        public Product() { }
        public Product(string name, int price, DateTime expirationDate, DateTime productionDate):base(name,price)
        {
            ProductionDate = productionDate;
            ExpirationDate = expirationDate;
            
        }
        
        public override string ToString()
        {
            
            return $"{base.ToString()}\nДата производства: {ProductionDate.ToShortDateString()}\nСрок годности: {ExpirationDate.ToShortDateString()}";
        }
        public override string DeadkineExpirationDate()
        {
            if(ExpirationDate<=DateTime.Now)
            {
                return $"Просроченный товар: {Name}\n\n";
            }
            else { return null; }
        }
    }
}
