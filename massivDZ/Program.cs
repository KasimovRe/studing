using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // дз 1. заполнить массив с клавиатуры

            Console.Write("Введите длину массива: ");
            int choice = int.Parse(Console.ReadLine());

            Console.ReadLine();

            int[] massiv = new int[choice];

            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write("Введите значение массива " + (i + 1) + ": ");
                massiv[i] = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();

            // дз 2. вывести массив в обратном порядке

            for (int i = (massiv.Length - 1); i >= 0; i--)
            {
                Console.WriteLine("Значение массива " + (i + 1) + " = " + massiv[i]);
            }
            Console.ReadLine();

            // дз 3. найти сумму четных чисел в массиве

            int sum = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                int number = massiv[i];

                if (number % 2 == 0)
                {
                    sum = sum + number;
                    continue;
                }
            }
            Console.WriteLine("Сумма четных чисел в массиве 'massiv' = " + sum);
            Console.ReadLine();

            // дз 4.найти наименьшее число в массиве

            int min = massiv[0];
            int a = 1, b = 0;
            do
            {
                if (massiv[a] > massiv[b])
                {
                    if (min > massiv[b])
                    {
                        min = massiv[b];
                    }

                }
                else
                {
                    if (min > massiv[b])
                    {
                        min = massiv[a];
                    }
                }

                a++; b++;

            }
            while (a < massiv.Length);
            Console.WriteLine("Наименьшее число из массива 'massiv' = " + min);
            Console.ReadLine();

            // повторение 4.

            int chet = massiv[0];
            for (int i = 0; i < massiv.Length; i++)
            {
                if (chet > massiv[i])
                {
                    chet = massiv[i];
                }
            }
            Console.WriteLine("Наименьшее число второго захода из массива 'massiv' " + " = " + chet);
            Console.ReadLine();
        }
    }
}
