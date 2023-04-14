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

            ConsoleArray(ref MyArray);

            Console.ReadLine();
        }

        static void ConsoleArray(ref int[] MyArray, int index = 0, int sum = 0)
        {
            if (index >= MyArray.Length)
            {
                Console.WriteLine(sum);
                return;
            }

            sum += MyArray[index];
            index++;

            ConsoleArray(ref MyArray, index, sum);
        }
    }
}
