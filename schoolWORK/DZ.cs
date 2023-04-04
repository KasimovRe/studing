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

            /* uint kolvo, chet, nechet; // uint потому что отриц чисел быть не может 
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

            Console.ReadLine(); */

  
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

            for (int i = 0 ; i < month ; i++)
            {
                sum += sum * 0.07M;
            }
            Console.WriteLine("Ваша сумма вклада по истечению " + month + " месяца(-ев) = " + sum);

            /* Упражнение 2
               Перепишите предыдущую программу, только вместо цикла for используйте цикл while */
            int i1 = 0;
            while (i1 < month)
            {
                sum1 += sum1 * 0.07M;
                i1++;
            }
            Console.WriteLine("Ваша сумма вклада #2 по истечению " + month + " месяца(-ев) = " + sum1);
            Console.ReadLine();

            /* Упражнение 3
               Перепишите предыдущую программу, только вместо цикла for используйте цикл while */

            Console.ReadLine();

        }
    }
}
