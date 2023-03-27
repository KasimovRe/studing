using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stud2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Мини-игра 'Угадай число от 170 до 180'");
            Console.WriteLine("Введите любое число");

            a = int.Parse(Console.ReadLine());
            if (a == 174)
            {
                Console.WriteLine("Вы угадали! Поздравляю!");
                Console.ReadLine();
            }
            else
            {
                if (a > 174)
                {
                    Console.WriteLine("Загаданное число меньше вашего");
                    Console.WriteLine("Перезапустите программу и попробуйте еще раз");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Загаданное число больше вашего");
                    Console.WriteLine("Перезапустите программу и попробуйте еще раз");
                    Console.ReadLine();
                }
            }
        }
    }
}
