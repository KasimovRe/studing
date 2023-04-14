using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_2
{
    internal class Program
    {
        // найти сумму элементов массива с помощью рекурсии
        static void Main(string[] args)
        {
            int[] MyArray = { 20, 30, 50 };
            int sum = 0;

            ConsoleArray(ref MyArray, index: 0, ref sum);
        }

        static void ConsoleArray(ref int[] MyArray, int index, ref int sum)
        {
            if (index == MyArray.Length)
            {
                Console.WriteLine(sum);
                return;
            }

            int number = MyArray[index];
            index++;

            Sum(ref number, ref sum);

            ConsoleArray(ref MyArray, index, ref sum);
        }

        static int Sum(ref int number, ref int sum)
        {
            sum += number;
            return sum;
        }
    }
}
