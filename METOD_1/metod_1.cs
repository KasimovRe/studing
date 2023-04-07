using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace METOD_1
{
    internal class metod_1
    {
        static void Converter(char a, int  b)
        {
            Console.WriteLine();
            for (int i = 0; i < b; i++)
            {
                Console.Write(a);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите знак, которым будет заполнена строка: ");
            char simbol = char.Parse(Console.ReadLine()); 
            Console.Write("Введите длину строки: ");
            int quantity = int.Parse(Console.ReadLine());

            Converter(simbol, quantity);

            Console.ReadKey();
        }
    }
}
