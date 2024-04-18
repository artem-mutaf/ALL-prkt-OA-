using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema19prkt3
{
    class Book:IComparable<Book>
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int CompareTo(Book item)
        {
            return string.Compare(this.Name,
            item.Name);
        }

    }
}
