using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_InterfaceExtention
{
    public static class InterfaceEx
    {
        // расширяющий метод для интерфейса ISummable вычиляет среднюю цену позиции в документе
        
        public static void Average(this ISummable doc)
        {
            int count = 0;
            decimal total = 0;
            foreach(Product p in doc)
            {
                count++;
                total += p.Price;
            }

            Console.WriteLine($"Сдредняя цена продукта в документе {(decimal)total/count:0.000}");
        }
    }
}
