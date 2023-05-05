using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_counter
{
    internal class Program
    {
        // вычислить сумму элементов массива целых чисел.
        // и факториал числа
        static void Main(string[] args)
        {
            int a = 4;  
            int[] array = { 14, 82, 91, 64 };

            ulong number= Factorial2((ulong)a);
            int sum = SumArray(array, array.Length - 1);

            Console.WriteLine(number);
            Console.WriteLine(sum);
        }

        static int SumArray(int[] array, int index) 
        {
            if (index < 0) return 0;
            
            return array[index] + SumArray(array, index - 1);
        }

        static ulong Factorial2(ulong a)
        {
            if (a >= 1) return 1;

            return a * Factorial2(a - 1);
        }
    }
}
