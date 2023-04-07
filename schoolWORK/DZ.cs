using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolWORK
{
    internal class DZ
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


            /* Упражнение 1
                За каждый месяц банк начисляет к сумме вклада 7 % от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев.
                А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
                
                Для вычисления суммы с учетом процентов используйте цикл for. 
                Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine())(сумма вклада будет представлять тип decimal). */

            Console.Write("Введите сумму денег для вклада: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите кол-во месяцев: ");
            decimal month = Convert.ToDecimal(Console.ReadLine());

            decimal sum1 = sum;

            for (int i = 0; i < month; i++)
            {
                sum += sum * 0.07M;
            }
            Console.WriteLine("\nВаша сумма вклада по истечению " + month + " месяца(-ев) = " + sum);
            Console.ReadKey();

            /* Упражнение 2
               Перепишите предыдущую программу, только вместо цикла for используйте цикл while */

            int i1 = 0;
            while (i1 < month)
            {
                sum1 += sum1 * 0.07M;
                i1++;
            }
            Console.WriteLine("Ваша сумма вклада #2 по истечению " + month + " месяца(-ев) = " + sum1);
            Console.ReadKey();

            /* Упражнение 3
               Напишите программу, которая выводит на консоль таблицу умножения */

            for (int i = 1; i <= 9; i++, Console.WriteLine())
            {
                Console.WriteLine();
                for (int j = 1; j <= 9; j++, Console.Write("\t"))
                {
                    int sum2 = i * j;
                    Console.Write(sum2);
                }
            }
            Console.ReadKey();

            //Упражнение 4

            while (true)
            {
                Console.Clear();

                Console.Write("Введите 1 число от 1 до 10: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.Write("Введите 2 число от 1 до 10: ");
                int number2 = int.Parse(Console.ReadLine());

                if ((number1 > 10 || number1 < 1) || (number1 >  10 || number1 < 1))
                {
                    Console.WriteLine("\nВаши числа не удволетворяют запросу. Введите числа повторно");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nПроизведение ваших чисел = " + number1*number2);
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
