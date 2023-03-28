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
            /* int a;

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
                } */

            Console.WriteLine("Введите число от 1 до 9");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("Ваше число 1");
            }
            else if (a == 2) 
            {
                Console.WriteLine("Ваше число 2");
            }
            else if (a == 3)
            {
                Console.WriteLine("Ваше число 3");
            }
            else if (a == 4)
            {
                Console.WriteLine("Ваше число 4");
            }
            else if (a == 5)
            {
                Console.WriteLine("Ваше число 5");
            }
            else if (a == 6)
            {
                Console.WriteLine("Ваше число 6");
            }
            else if (a == 7)
            {
                Console.WriteLine("Ваше число 7");
            }
            else if (a == 8)
            {
                Console.WriteLine("Ваше число 8");
            }
            else if (a == 9)
            {
                Console.WriteLine("Ваше число 9");
            }
            else
            {
                Console.WriteLine("Ваше число не подходит");
            }
            Console.ReadLine();
        }
    }
}
