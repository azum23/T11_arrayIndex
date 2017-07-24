using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Перегрузка операций на примере класса Cyborg состоящего из элементов.
// Для примера взят класс киборг, по смыслу такой же как перегружать операторы условной машины - бессмысленно.
// Но точки и прямоугольники уже надоели.

namespace T11_operatorOverride_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cyborg c1 = new Cyborg("Crusher");
            c1.AddElement(new Element("Миксер", "Перемалывает в труху"));
            c1.AddElement(new Element("Пулемет", "Стреляет патронами"));

            Cyborg c2 = new Cyborg("RepairMan", new List<Element>()
            {
                new Element("Длань Божья", "Лечит все к чему прикоснеться"),
                new Element("Бутыль святой воды", "Заливает ржавчину"),
            });

            var c3 = c1 + c2;
            Console.WriteLine(c3.ToString());
            Console.WriteLine(c3.GetHashCode());
            
            
            // проверяем ++
            c3++;
            Console.WriteLine(c3.ToString());
            Console.WriteLine(c3.GetHashCode()); // проверяем тот же обьект?

            // проверяем +=
            c3 += c1;
            Console.WriteLine(c3.ToString());
            Console.WriteLine(c3.GetHashCode());

            // проверяем > < == !=
            Console.WriteLine(c1>c2);
            Console.WriteLine(c1 < c2);

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 != c2);

            Console.ReadLine();
        }
    }
}
