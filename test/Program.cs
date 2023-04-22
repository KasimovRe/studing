using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    // НАПИСАТЬ КОД, КОТОРЫЙ показывает сколько стоит напиток
    // фанта - 100р, черноголовка - 200р, кола - нет
    // пользователь вводит номер сока и на консоль выводится его цена
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a day of the week:");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, out DayOfWeek day))
                Console.WriteLine($"You chose {day}");
            else
                Console.WriteLine("Invalid input");
        }
        enum DayOfWeek
        {
             Monday = 1,
             Tuesday,
             Wednesday,
             Thursday,
             Friday,
             Saturday,
             Sunday
        }
    }
}
        