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

            int[] massiv = new int[4];

            for (int i = 0; i < massiv.Length; i++)
            {
                Console.WriteLine("Введите значение массива " + i);
                massiv[i] = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();

            // дз 2. вывести массив в обратном порядке
            
            for (int i = (massiv.Length - 1); i >=0; i--)
            {
                Console.WriteLine("Значение массива " + i + " = " + massiv[i]);
            }
            Console.ReadLine();

            // дз 3. найти сумму четных числе в массиве

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
        }
    }
}
