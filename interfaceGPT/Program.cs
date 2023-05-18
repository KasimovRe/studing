using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceGPT
{
    // Создать интерфейс IShape с методами calculateArea() и draw().
    // Реализовать этот интерфейс в классах Circle, Rectangle и Triangle.
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle()
            {
                R = 2
            };

            IShape rectangle = new Rectangle()
            {
                Height = 2,
                Weight = 5
            };

            IShape triangle = new Triangle()
            {
                A = 3,
                Height = 1.5,
            };

            Console.WriteLine(circle.CalculateArea());
            circle.Draw();

            Console.WriteLine($"\n{rectangle.CalculateArea()}\n");
            triangle.Draw();

        }

    }
}
