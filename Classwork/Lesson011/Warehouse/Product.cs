using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson011.Warehouse
{
    public class Product
    {
        public string Name { get; private set; }
        public uint Price { get; private set; }

        public Product(string name, uint price)
        {
            Name = name;
            Price = price;
        }
    }
}
