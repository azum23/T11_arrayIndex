using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_Cast_01
{
    class Rectangle
    {
        public int width = 1;
        public int height = 1;
        public Point start;

        public Rectangle(int x, int y)
        {
            width = x;
            height = y;
        }

        // преобразование прямоуголинка в квадрат идет через создание квадрата равного по площади.
        public static explicit operator Square(Rectangle r)
        {
            int area = r.width * r.height;
            int side = (int)area / 2;
            Square s = new Square(side);
            return s;
        }

        // преобразование к int идет через вычисление площади
        public static explicit operator int(Rectangle r)
        {
            return r.width * r.height;
        }

        public void Draw()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine("");
            }
        }
    }
}
