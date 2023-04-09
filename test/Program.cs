﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        // написать код, который выводит массив, написаннный с клавы
        // если значение пользователя null - заполнить строку -1
        static void Main(string[] args)
        {
            /*
            int[] array = { 1, 7, 12, 221, 43, 6, 92, 4, 9, 7};

            Console.Write("Введите число из массива, чей индекс хотите узнать: ");
            int number = int.Parse(Console.ReadLine());

            if (array.Contains(number)) // проверяет на наличие нужного значения
            {
                int result = Array.FindIndex(array, i => i == number); // находит индекс
                Console.WriteLine("Индекс вашего числа = " + "[" + result + "]");
            }
            else
                Console.WriteLine("Вашего числа нет в массиве");

            Console.ReadKey();
            */

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
