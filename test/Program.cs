﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int visot3 = 1; visot3 <= 10; visot3++) // высота на 10 строчек
            //{
            //    for (int kolvocpust3 = 10; kolvocpust3 > visot3; kolvocpust3--) // если строчка 1, то прбелов 9
            //    {
            //        Console.Write(' ');
            //    }

            //    for (int kolvo3 = 1; kolvo3 <= visot3 ; kolvo3++)
            //    {
            //        Console.Write('#');
            //    }
            //    Console.WriteLine();
            //}

            //for (int visot4 = 0; visot4 <= 10; visot4++) // высота на 10 строчек
            //{
            //    for (int kolvo4 = 10; kolvo4 > visot4; kolvo4--)
            //    {
            //        Console.Write('#');
            //    }
            //    Console.WriteLine();

            //    for (int kolvocpust4 = 0; kolvocpust4 <= visot4; kolvocpust4++) // если строчка 1, то прбелов 9
            //    {
            //        Console.Write(' ');
            //    }

            //}

            // код выводит число с консоли. если отриц = 0

            string[] massa = new string[10];

            massa[3] = "hello and";
            massa[4] = " slava sovetskomu soyuzu";

            Console.WriteLine(massa[3] + massa[4]);
            Console.WriteLine(massa.Length);

            int[] massiv = new int[] { 1, 2, 3, 5 };

            for (int i = 0; i < massiv.Length; i++)
            {
                Console.WriteLine(massiv[i]);
            }

            Console.ReadLine();
        }
    }
}
