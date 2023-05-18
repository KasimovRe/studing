using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceGPT
{
    internal class Circle : IShape
    {
        public double R { get; set; }
        const double Pi = 3.14;
        public double CalculateArea()
        {
            return Math.Pow(R, 2) * Pi;
        }

        public void Draw()
        {
            Console.WriteLine("Я круг. Я рисуюсь, а следовательно - существую.");
        }
    }
}
