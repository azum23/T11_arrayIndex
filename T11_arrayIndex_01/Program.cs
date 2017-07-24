using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Содание индексатора для коллекции списка продуктов, индекскция по int и string

namespace T11_arrayIndex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список продуктов
            ProductList products = new ProductList();
            products.Add(new Product("Coca-cola"));
            products.Add(new Product("Sprite"));
            products.Add(new Product("Fanta"));
            Console.WriteLine(products[0].name);

            // Заменяем продукт в списке по индексу
            Product newProduct = new Product("Jack Daniels");
            products[0] = newProduct;
            Console.WriteLine(products[0].name);

            // Индексация (поиск) по имени продукта, возвращает индекс пролукта int
            string searched = "Fanta";
            int index = products[searched];
            if (index >= 0)
            {
                Console.WriteLine($"Найденный индекс {index} искали по слову {searched}, нашли {products[index].name}");
            }
            else
            {
                Console.WriteLine($"Продукт {searched} не найден");
            }


            // Delay
            Console.ReadKey();
        }
    }
}
