using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rec_1
{
    internal class Program
    {
        // кодЮ который выводит массив с помощью рекурсии
        static void Main(string[] args)
        {
            int[] MyArray = { 19, 42, 73, 52, 96, 10, 64 };

            ConsoleArray(ref MyArray, 0);
        }

        static void ConsoleArray(ref int[] MyArray, int index)
        {
            if (index == MyArray.Length)
                return;

            Console.WriteLine(MyArray[index]);
            index++;

            ConsoleArray(ref MyArray, index);

        }

    }
}
