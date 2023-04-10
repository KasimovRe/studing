using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_null
{
    internal class Program
    {
        // написать код, который выводит массив, написаннный с клавы
        // если значение пользователя null - заполнить строку "нет данных"

        static void Main(string[] args)
        {
            Console.Write("Укажите размер массива: ");
            int lenghtNumberUser = int.Parse(Console.ReadLine());

            Console.WriteLine("\nЗаполните массив.");
            string[] MyArray = Сounter(lenghtNumberUser);

            Console.WriteLine("\nВаш массив:");
            Conclusion(MyArray);

            Console.ReadKey();
        }

        /// <summary>
        /// Заполняет массив с клавиатуры и обрабатывает исключения
        /// </summary>
        /// <param name="lenghtNumberUser"></param>
        /// <returns></returns>
        static string[] Сounter(int lenghtNumberUser)
        {
            string[] MyArray = new string[lenghtNumberUser];

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write("Введите значение №" + (i + 1) + ": ");
                String MyArrayStr = Console.ReadLine();
                string result = MyArrayStr ?? "нет данных";
                MyArray[i] = result;
            }
            return MyArray;
        }

        /// <summary>
        /// Выводит на консоль массив
        /// </summary>
        /// <param name="MyArray"></param>
        /// <returns></returns>
        static string[] Conclusion(string[] MyArray)
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write(MyArray[i] + "\t");
            }
            return MyArray;
        }
    }
}
