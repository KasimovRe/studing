using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number1 number1 = new Number1 { Number = 10 };
            Number1 number11 = new Number1 { Number = 10 };
            Number2 number2 = new Number2 { Number = 10 };

            Sum(ref number1);
            Console.WriteLine(number1.Number);

            Sum(number11);
            Console.WriteLine(number11.Number);

            Sum(number2);
            Console.WriteLine(number2.Number);

            Console.ReadKey();
        }
        static void Sum(ref Number1 number) { number.Number++; }
        static void Sum(Number1 number) { number.Number++; }
        static void Sum(Number2 number) { number.Number++; }
    }

    struct Number1 { public int Number { get; set; } }

    class Number2 { public int Number { get; set; } }
}
