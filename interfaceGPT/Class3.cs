using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceGPT
{
    internal class Triangle : IShape
    {
        public double Height { get; set; }
        public double A { get; set; }
        public double CalculateArea()
        {
            return (Height * A) / 2;
        }

        public void Draw()
        {
            Console.WriteLine("Я треугольник. Я мечусь. Мои принципы зависят от изначального преобразования меня");
        }
    }
}
