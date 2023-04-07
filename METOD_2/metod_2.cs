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

            Counter(number, array);
        }

        static void Counter(int number, int[] array)
        {
            int a = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    Console.WriteLine("Индекс введенного числа = " + "[" + i + "]");
                    Console.ReadKey();
                    break;
                }
                else if (a == array.Length)
                {
                    Console.WriteLine("Вашего числа нет в массиве");
                    Console.ReadKey();
                    break;
                }
                a++;
            }
        }
    }
}
