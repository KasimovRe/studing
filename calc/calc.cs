using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class calc
    {
        static void Main(string[] args)
        {
            //пишем ццикл, который повторяется 2 раза
            //и в нем же еще 1 цикл для вывода 2 разных треугольников
            //то есть выводит один шарп, цикл кончается, след строчка, два шарп, цикл кончается, и тд

            Console.WriteLine("Введите размер треугольника цифрой");
            int height = int.Parse(Console.ReadLine());

            if (height < 0)
            {
                Console.WriteLine("Нельзя вводить отрицательные значения!");
                return;
            }
            
            for (int tr12 = 0; ; tr12++)
            {
                for (int visot1 = 0 ; visot1 <= height; visot1++)
                {
                    for (int kolvoc1 = 0; kolvoc1 < visot1; kolvoc1++)
                    {
                        Console.Write('#');
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine();

                for (int visot2 = 0; visot2 <= height; visot2++)
                {
                    for (int kolvoc2 = height; kolvoc2 > visot2; kolvoc2--)
                    {
                        Console.Write('#');
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();


                for (int visot3 = 1; visot3 <= height; visot3++) // высота на 10 строчек
                {
                    for (int kolvocpust3 = height; kolvocpust3 > visot3; kolvocpust3--) // если строчка 1, то прбелов 9
                    {
                        Console.Write(' ');
                    }

                    for (int kolvo3 = 1; kolvo3 <= visot3; kolvo3++)
                    {
                        Console.Write('#');
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine();


                for (int visot4 = 0; visot4 <= height; visot4++) // высота на 10 строчек
                {
                    for (int kolvo4 = height; kolvo4 > visot4; kolvo4--)
                    {
                        Console.Write('#');
                    }
                    Console.WriteLine();

                    for (int kolvocpust4 = 0; kolvocpust4 <= visot4; kolvocpust4++) // если строчка 1, то прбелов 9
                    {
                        Console.Write(' ');
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
