using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceGPT
{
    internal class Rectangle : IShape
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public double CalculateArea()
        {
            return Weight * Height;
        }

        public void Draw()
        {
            Console.WriteLine("Я прямоугольник. Я обозначаюсь. У меня есть четкие границы, которые все должны соблюдать");
        }
    }
}
