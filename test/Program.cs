using System;
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
        { /*
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

            Console.ReadKey(); */
            int lenght = int.Parse(Console.ReadLine());
            string[] MyArray = new string[lenght];

            MyArray[0] = Console.ReadLine();
            string[] Str = new string [1];
            Str[0] = MyArray[0];

            string result = Str[0] ?? "нет данных";
            if (MyArray[0] == null)
            {
                Console.WriteLine(MyArray[0] = "нет данных");
            }
            else
            {
                Console.WriteLine(MyArray[0]);
            }
            Console.WriteLine(result);

            Console.ReadKey();
        } 
    }
}
