using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
            /*
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
            */

            //Упражнение 1.1
            // даны целые числа К и N (N>0). Вывести N раз число K

            int K = 5;
            int N = 3;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(K);
            }
            Console.WriteLine("------------------------/ 1.1 /------------------------\n");

            //Упражнение 1.4
            // дано вещественное число - 1кг конфет. узнать стоимость 1, 2 ... 10 кг

            double OnePrice1kg = 100;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(OnePrice1kg * i);
            }
            Console.WriteLine("------------------------/ 1.4 /------------------------\n");

            //Упражнение 1.5
            // дано вещественное число - 1кг конфет. узнать стоимость 0.1, 0.2 ... 1 кг

            double TwoPrice1kg = 100;

            for (double i = 1; i <= 10; i++)
            {
                double mass = i / 10;
                Console.WriteLine(TwoPrice1kg * mass);
            }
            Console.WriteLine("------------------------/ 1.5 /------------------------\n"); 

            //Упражнение 1.6
            // дано вещественное число - 1кг конфет. узнать стоимость 1.2, 1.4  ... 2 кг
            
            double ThreePrice1kg = 100;

            for (double i = 1.2; i <= 2; )
            {
                Console.WriteLine(ThreePrice1kg * i);
                i += 0.2;
            }
            Console.WriteLine("------------------------/ 1.6 /------------------------\n");

            //Упражнение 1.7
            // даны два целых числа А и В (А<В). Найти сумму всех чисел от А до В включительно

            int A = 1;
            int B = 5;
            int sum = 0;

            for (; A <= B; A++)
            {
                sum += A;
            }
            Console.WriteLine(sum);
            Console.WriteLine("------------------------/ 1.7 /------------------------\n");

            //Упражнение 2.1

            int[] OneMyArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sumOneMyArray = 0;

            for (int i = 0; i < 10; i++)
            {
                sumOneMyArray += OneMyArray[i];
            }
            Console.WriteLine(sumOneMyArray);
            Console.WriteLine("------------------------/ 2.1 /------------------------\n");

            //Упражнение 2.2

            int[] TwoMyArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sumTwoMyArray = 1;

            for (int i = 0; i < 10; i++)
            {
                sumTwoMyArray *= TwoMyArray[i];
            }
            Console.WriteLine(sumTwoMyArray);
            Console.WriteLine("------------------------/ 2.2 /------------------------\n");

            //Упражнение 2.3

            int[] ThreeMyArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double sumThreeMyArray = 0;
            double average;

            for (int i = 0; i < 10; i++)
            {
                sumThreeMyArray += ThreeMyArray[i];
            }
            average = sumThreeMyArray / 10;
            Console.WriteLine(average);
            Console.WriteLine("------------------------/ 2.3 /------------------------\n");


            //Упражнение 2.4

            int NN = 3;
            double[] FourMyArray = new double [NN];
            FourMyArray[0] = 1.4;
            FourMyArray[1] = 3.2;
            FourMyArray[2] = 6.7;

            double sumFourMyArray = 0;
            double OnePOF = 1;

            for (int i = 0; i < NN; i++)
            {
                sumFourMyArray += FourMyArray[i];
                OnePOF *= FourMyArray[i];
            }
            Console.WriteLine(sumFourMyArray);
            Console.WriteLine(OnePOF);
            Console.WriteLine("------------------------/ 2.4 /------------------------\n");

            //Упражнение 2.5

            int NNN = 3;
            double[] FiveMyArray = new double[NN];
            FiveMyArray[0] = 1.4;
            FiveMyArray[1] = 3.2;
            FiveMyArray[2] = 6.7;

            double sumFiveMyArray = 0;

            for (int i = 0; i < NNN; i++)
            {
                double fraction = FiveMyArray[i] % 1;
                FiveMyArray[i] -= fraction;
                Console.WriteLine(FiveMyArray[i]);
            }

            for (int i = 0; i < NNN; i++)
            {
                double fraction = FiveMyArray[i] % 1;
                FiveMyArray[i] -= fraction;
                sumFiveMyArray += FiveMyArray[i];
            }
            Console.WriteLine(sumFiveMyArray);
            Console.WriteLine("------------------------/ 2.5 /------------------------\n");
        }
    }
}
