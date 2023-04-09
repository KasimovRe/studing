using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_TryCatch
{
    internal class Program
    {
        // написать код, который выводит массив, написаннный с клавы
        // если значение пользователя null - заполнить строку -1

        static void Main(string[] args)
        {
            Console.Write("Укажите размер массива: ");
            int lenghtNumberUser = int.Parse(Console.ReadLine());

            Console.WriteLine("\nЗаполните массив числами.");
            int[] MyArray = Сounter(lenghtNumberUser);

            Console.WriteLine("\nВаш массив:");
            Conclusion(MyArray);

            Console.ReadKey();
        }

        /// <summary>
        /// Заполняет массив с клавиатуры и обрабатывает исключения
        /// </summary>
        /// <param name="lenghtNumberUser"></param>
        /// <returns></returns>
        static int[] Сounter(int lenghtNumberUser)
        {
            int[] MyArray = new int[lenghtNumberUser];

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write("Введите значение №" + (i + 1) + ": ");
                try
                {
                    MyArray[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    MyArray[i] = -1;
                }
            }
            return MyArray;
        }

        /// <summary>
        /// Выводит на консоль массив
        /// </summary>
        /// <param name="MyArray"></param>
        /// <returns></returns>
        static int[] Conclusion(int[] MyArray)
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write(MyArray[i] + "\t");
            }
            return MyArray;
        }
    }
}
