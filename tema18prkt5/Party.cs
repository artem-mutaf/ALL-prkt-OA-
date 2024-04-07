using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema18prkt5
{
    class Party:Goods
    {
        public int Count { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime ProductionDate { get; set; }
        public Party() { }
        public Party(string name,int price, int count,DateTime productionDate, DateTime expirationDate) :base(name,price)
        {
            Count = count;
            ExpirationDate = expirationDate;
            ProductionDate = productionDate;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nКоличество: {Count}\nДата производства: {ProductionDate.ToShortDateString()}\nСрок годности: {ExpirationDate.ToShortDateString()}";
        }
        public override string DeadkineExpirationDate()
        {
            if (ExpirationDate <= DateTime.Now)
            {
                return $"Просроченный товар: {Name}\n\n";
            }
            else { return null; }
        }
    }
}
