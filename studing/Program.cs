using System;

namespace studing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! and My planned game");

            // программа для конвертации валют (нединамичная)
            Console.WriteLine("Кол-во руб.");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько у тебя долларов: " + (r / 75));

        }
    }
}
