using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolWORK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //написать программу которая считает кол во четных и нечетных чисел в том диапозоне, который указал пользователь

            uint kolvo, chet, nechet; // uint потому что отриц чисел быть не может 
            kolvo = 0;
            chet = 0;
            nechet = 0;

            Console.WriteLine("Введите диапозон:");
            Console.WriteLine("От какого числа начать отсчет...");
            int diapozon1 = int.Parse(Console.ReadLine());
            Console.WriteLine("До какого числа начать отсчет...");
            int diapozon2 = int.Parse(Console.ReadLine());

            if (diapozon2 < diapozon1)
            {
                Console.WriteLine("Вы ввели неверные значения");
                Console.ReadLine();
                return;
            }

            int diapozon = diapozon2 - diapozon1;


            while (kolvo < diapozon)
            {
                kolvo++;

                if (kolvo % 2 == 0)
                    chet++;
                else
                    nechet++;
            }

            Console.WriteLine("Кол во четных чисел = " + chet);
            Console.WriteLine("Кол во нечетных чисел = " + nechet);
            Console.WriteLine("Сумма всех чисел/ диапозон = " + (chet + nechet));

            Console.ReadLine();

        }
    }
}
