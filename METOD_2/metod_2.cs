using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METOD_2
{
    internal class metod_2
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 54, 82, 15, 19, 4, 54, 2};

            Console.Write("Введите число из массива, чей индекс хотите узнать: ");
            int number = int.Parse(Console.ReadLine());

            int index = Counter(number, array);

            if (index >= 0)
            {
                Console.WriteLine("Индекс вашего числа = " + "[" + index + "]");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Вашего числа нет в массиве");
            Console.ReadKey();
        }

        static int Counter(int number, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
