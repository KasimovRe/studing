using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avbstractGPT
{
    // Создать абстрактный класс Figure с абстрактным методом calculateArea().
    // Унаследовать от него классы Circle и Rectangle и реализовать в них
    // метод calculateArea() для вычисления площади круга и прямоугольника.
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure circle = new Circle()
            {
                R = 10
            };

            Figure rectangle = new Rectangle()
            {
                Weight = 5,
                Height = 3
            };

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(rectangle.CalculateArea());

        }
    }
    abstract class Figure { public abstract double CalculateArea(); }

    class Circle : Figure
    {
        public int R { get; set; }

        public override double CalculateArea()
        {
            double S = (Math.Pow(R, 2) * 3.14);
            return S;
        }
    }

    class Rectangle : Figure
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public override double CalculateArea()
        {
            double S = Weight * Height;
            return S;
        }
    }
}
