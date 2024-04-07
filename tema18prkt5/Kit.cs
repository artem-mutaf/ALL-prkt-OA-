using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema18prkt5
{
    class Kit : Goods
    {
        public string Products { get; set; }

        public Kit() { }
        public Kit(string name, int price, string products) : base(name, price)
        {
            Products = products;
        }
        public override string DeadkineExpirationDate()
        {
            return null;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nПродукты: {Products}";
        }
    }
}
