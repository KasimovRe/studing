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
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Сколько у тебя долларов: " + (r / 75));
            Console.WriteLine("Сколько у тебя евро: " + (r / 85));
            Console.ReadLine();
            
            //по сравнению с 14 летками, которые учатся этому уже несколько лет, мое "творение" жалко

        }
    }
}
