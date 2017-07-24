using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_InterfaceExtention
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product (string _name, decimal _price)
        {
            Name = _name;
            Price = _price;
        }
    }
}
