using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// преобразование типов на примере квадрата и прямоугольника. Через перевод площади прямоугольника
// в квадрат аналогичной площади и стартовой точки.

namespace T11_Cast_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 3);
            Square s = new Square(5);

            s.Draw();
            Console.WriteLine();
            r.Draw();
            Console.WriteLine();

            // преобразуем прямоугольник в квадрат 4 * 3 = 12 / 2 = 6.
            s = r;
            s.Draw();

            // и квадрат в int
            int a = (int)s;
            Console.WriteLine(a);

            

            Console.ReadKey();
        }
    }
}
