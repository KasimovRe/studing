using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    // НАПИСАТЬ КОД, КОТОРЫЙ показывает сколько стоит напиток
    // фанта - 100р, черноголовка - 200р, кола - нет
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите напиток: fanta, cola, chernogolovka\n");
            string choice = Console.ReadLine();

            Napitok napitok = Enum.Parse(typeof Napitok, choice, );

            switch (Napitok)
            {
                case Napitok.fanta:
                    break;
                case Napitok.cola:
                    break;
                case Napitok.chernogolovka:
                    break;
                default:
                    break;
            }
        }

        enum Napitok
        {
            fanta,
            cola,
            chernogolovka
        }
    }
}
        