using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_arrayIndex_01
{
    class ProductList
    {
        private Product[] productList = new Product[0];

        public void Add(Product item)
        {
            Product[] temp = new Product[productList.Length + 1];
            for (int i = 0; i < productList.Length; i++)
            {
                temp[i] = productList[i];
            }
            temp[temp.Length - 1] = item;
            productList = temp;
        }

        // Индексатор по int
        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < productList.Length)
                {
                    return (Product)productList[index];
                }
                return null;
            }
            set { productList[index] = value; }
        }

        /// <summary>
        /// Индесирует коллекцию по string имени продукта
        /// </summary>
        /// <param name="_name">Имя продукта Product.name</param>
        /// <returns>int index наденного продукта, -1 если продукт не найден</returns>
        public int this[string _name]
        {
            get
            {
                for (int i = 0; i < productList.Length; i++)
                {
                    if (productList[i].name == _name)
                    {
                        return i;
                    }
                }
                return -1;
            }
          
        }

    }
}
