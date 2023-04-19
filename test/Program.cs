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
            Console.Write("Выберите напиток из списка: ");

            foreach (var convert in Enum.GetNames(typeof(Napitok)))
            {
                Console.Write($"{convert}; ");
            }
            Console.WriteLine("\n");

            string choice = Console.ReadLine();
            Converter(ref choice);
            int number = int.Parse(choice);

            Napitok napitok = (Napitok)number;

            switch (napitok)
            {
                case Napitok.fanta:
                    Console.WriteLine($"Напиток: {napitok}  |  Цена: 100р");
                    break;
                case Napitok.cola:
                    Console.WriteLine($"Напиток: {napitok}  |  Цена: нет в наличии");
                    break;
                case Napitok.chernogolovka:
                    Console.WriteLine($"Напиток: {napitok}  |  Цена: 200р");
                    break;
            }

        }

        /// <summary>
        /// Представляяет собой список доступных напитков
        /// </summary>
        enum Napitok: byte
        {
            fanta = 1,
            cola,
            chernogolovka
        }

        /// <summary>
        /// Конвертирует строку пользователя в номер enum
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        static string Converter(ref string choice)
        {
            switch (choice)
            {
                case "fanta":
                    choice = "1";
                    return choice;
                case "cola":
                    choice = "2";
                    return choice;
                case "chernogolovka":
                    choice = "3";
                    return choice;
            }
            return "-1";
        }

    }
}
        