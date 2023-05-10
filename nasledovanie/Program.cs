using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie
{
    // Создайте базовый класс Shape.
    // В нем определите поля color и filled и метод Draw()
    // Создайте производные классы Circle и Rectangle, р
    // реализуйте их метод Draw().
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle curcle = new Circle();
            {
                Color = 
            }
        }
    }

    class Shape
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public void Draw()
        {
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Размер: {Size} x {Size}");
        }
    }
    class Circle : Shape { }
}
