using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    internal class genericsGPT
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> // объявляем и инициализируем лист типа инт
            {
                193, 122, 8, 0, 93, 1
            };

            List<int> list2 = new List<int> // объявляем и инициализируем лист типа инт
            {
                2, 4, 9, 18, 7
            };

            Method1(list1);

            Console.WriteLine("\n");

            list1.Sort();
            Method(list1);

            Console.WriteLine("\n");

            // след метод

            Method(list2);
            Console.WriteLine();
            Method2(list1, list2);


            Console.ReadKey();
        }

        // Создайте список чисел. Используя цикл, удвоьте значение каждого элемента списка.
        static void Method1(List<int> list1)
        {
            Console.Write("Удваиваем значения: ");
            for (int i = 0; i < list1.Count; i++) // можем сделать это так
            {
                list1[i] *= 2;
                Console.Write($"{list1[i]} | ");
            }
        }
        static void Method(List<int> list1)
        {
            Console.Write("Выводим: ");
            for (int i = 0; i < list1.Count; i++) 
            {
                Console.Write($"{list1[i]} | ");
            }
        }

        // Реализуйте метод, который находит произведение пар элементов двух списков.
        // Например: [1,2], [3,4] → [3, 8].
        static void Method2(List<int> list1, List<int> list2)
        {
            Console.Write("Умножаем пары чисел: ");
            for (int i = 0; i < list1.Count && i < list2.Count; i++)
            {
                var number =  list1[i] * list2[i];
                Console.Write($"{number} | ");
            }
        }
    }
}
