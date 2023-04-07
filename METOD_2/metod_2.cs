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
            Console.Write("Введите размер массива: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите диапозон масссива");
            Console.Write("\nОт: ");
            int minNumber = int.Parse(Console.ReadLine());

            Console.Write("До: ");
            int maxNumber = int.Parse(Console.ReadLine());

            int[] array = RandomArray(length, minNumber, maxNumber);

            Console.Write("\nВведите число из массива, чей индекс хотите узнать: ");
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

        static int[] RandomArray(int length,int minNumber, int MaxNumber)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(minNumber, MaxNumber);
            }

            return array;
        }
    }
}
