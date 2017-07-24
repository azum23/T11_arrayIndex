using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Реалиазация расширения для классов наследющих интерфейс.
// Класс BuyDocument и SaleDocument содержат список продуктов с указанием цены
// Интерфейс определяет метод вычисления общей суммы по документу
// Расширяющий метод InterfaceEx.Average вычисляет среднюю сумму по документу


namespace T11_InterfaceExtention
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productsBuy = new List<Product>()
            {
                new Product("Computer", 122.4M),
                new Product("Notebook", 17.3M),
                new Product("Phone", 22.4M),
            };

            List<Product> productsSale = new List<Product>()
            {
                new Product("Analitycs", 200.5M),
                new Product("Consulting", 300M),
            };

            BuyDocument bd = new BuyDocument(productsBuy);
            SaleDocument sd = new SaleDocument(productsSale);

            ISummable[] listDoc = new ISummable[2];
            listDoc[0] = bd;
            listDoc[1] = sd;

            foreach(var item in listDoc)
            {
                item.Average();
            }

            Console.ReadKey();
        }
    }
}
