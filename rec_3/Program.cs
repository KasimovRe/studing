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
            int a = 27349;

            Console.WriteLine(a % 10); // 9

            Console.WriteLine((a / 10) % 10); // 4
            Console.WriteLine((a / 100) % 10); // 3
            Console.WriteLine((a / 1000) % 10); // 7

            Console.WriteLine(a / 10000); // 2
        }

    }
}
