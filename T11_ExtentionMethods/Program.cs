using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// расширяющие методы

namespace T11_ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10232;
            Console.WriteLine(x);
            Console.WriteLine("перевертышь: " + x.Reverse());
            Console.ReadLine();
        }
    }
}
