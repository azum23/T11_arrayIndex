using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_Cast_01
{
    class Square
    {
        public int side = 1;

        public Point start;

        public Square(int x)
        {
            side = x;
        }

        // Преобразование квадрата в прямоугольник. Неявное
        public static implicit operator Square(Rectangle r)
        {
            int newSide = (int)r.height * r.width / 2;
            Square s = new Square(newSide);
            return s;
        }

        // преобразование к int идет через вычисление площади
        public static explicit operator int(Square s)
        {
            return s.side * s.side;
        }

        public void Draw()
        {
            for (int i = 0; i < side; i ++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine("");
            }
        }
    }
}
