using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_InterfaceExtention
{
    class BuyDocument : ISummable, IEnumerable
    {
        public List<Product> items;

        public decimal GetSum
        {
            get
            {
                decimal summ = 0;
                foreach(Product p in items)
                {
                    summ += p.Price;
                }
                return summ;
            }
        }

        public BuyDocument(List<Product> list)
        {
            items = list;
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
