using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rec_3
{
    internal class Program
    {
        // найти сумму числа с помощью рекурсии (561 = 12)
        // надо написать такой код, где мы будем каждый раз делить на 10. если остаток меньше 10, то начать код. либо *10 и повторить
        // сам код будет делить числа, начиная с большего, и вычитать остаток. Это будет помещаться в переменную, которая будет скалдываться со след остатками
        static void Main(string[] args)
        {
            int number2 = 2759;

            Console.WriteLine(number2 / 10); // 275
            Console.WriteLine(number2 % 10); //9

            Console.WriteLine(number2 / 100); // 27
            Console.WriteLine(number2 % 100); // 59

            Console.WriteLine(number2 / 1000); // 2
            Console.WriteLine(number2 % 1000); // 2


            Console.WriteLine("\n-------------------------------------------------\n");


        }

    }
}
