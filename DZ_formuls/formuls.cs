using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_formuls
{
    internal class formuls
    {
        
            // написать метод для поиска индекса элемента массива (тип эллементов в массиве - int)
            // метод должен вернуть индекс первого найденного элемента (если он будет) 

        static void Main(string[] args)
        {
            Console.Write("Укажите размер массива: ");
            int lenghtNumberUser = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значия массива, указав диапозон чисел ОТ и ДО");

            Console.Write("От: ");
            int value_1 = int.Parse(Console.ReadLine());

            Console.Write("До: ");
            int value_2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите число, чей индекс хотите узнать");
            int indexNumberUser = int.Parse(Console.ReadLine());

            int indexNumber = Сounter(Filler(lenghtNumberUser, value_1, value_2), indexNumberUser);

            Console.Write("\nИндекс вашего числа = " + "[" + indexNumber + "]");

            Console.ReadKey();
        }

        /// <summary>
        /// Заполняет массив рандомными числами в диапозоне и размером, указанным изначально
        /// </summary>
        /// <param name="lenghtNumberUser"></param>
        /// <param name="value_1"></param>
        /// <param name="value_2"></param>
        /// <returns></returns>
        static int[] Filler(int lenghtNumberUser, int value_1, int value_2)
        {
            Random random = new Random();
            int range = value_2 - value_1;

            int[] MyArray = new int[lenghtNumberUser];

            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = random.Next(range);
            }

            return MyArray;
        }

        /// <summary>
        /// Проверяет на наличие числа в массиве, указанным изначально
        /// </summary>
        /// <param name="MyArray"></param>
        /// <param name="indexNumberUser"></param>
        /// <returns></returns>
        static int Сounter(int[] MyArray, int indexNumberUser)
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (indexNumberUser == MyArray[i])
                {
                    int result = MyArray[i];
                    return result;
                }
            }
            return -1;
            
        }
    }
}
