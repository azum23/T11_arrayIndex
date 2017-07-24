using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_anonymusType
{
    class Program
    {
        static void Reflector(object obj)
        {
            Console.WriteLine(obj.GetType().Name);
            Console.WriteLine(obj.GetType().BaseType);
        }

        static void Main(string[] args)
        {
            var car = new { Name = "Lambo", maxSpeed = 300 };
            Console.WriteLine(car.Name);
            Console.WriteLine(car.ToString());
            Reflector(car);
            var car2 = new { Name = "BMW", maxSpeed = 200 };
            Console.WriteLine(car.Equals(car2));
            Console.ReadLine();
        }
    }
}
