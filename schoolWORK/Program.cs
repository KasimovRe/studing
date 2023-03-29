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
            // пишем простейший калькулятор if else

            double number1, number2;
            string simvol;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Для корректной работы простейшего калькулятора, вводите только два числа");
                Console.WriteLine("При указании алгебраического метода вводите только номер операции");
                Console.WriteLine("Если программа крашнется, то не обижайтесь)");

                Console.WriteLine("");

                Console.WriteLine("Введите номер операции:");
                Console.WriteLine("---");

                Console.WriteLine("Сложение (+) = 1");
                Console.WriteLine("Вычитание (-) = 2");
                Console.WriteLine("Деление (/) = 3");
                Console.WriteLine("Умножение (*) = 4");

                simvol = Console.ReadLine();

                if ((simvol == "1") || (simvol == "2") || (simvol == "3") || (simvol == "4"))
                {
                    Console.WriteLine("");
                    Console.WriteLine("---");
                    Console.WriteLine("Введите первое число:");
                    number1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    number2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    if (simvol == "1")
                    {
                        Console.WriteLine("---");
                        Console.WriteLine("Ccумма ваших чисел = " + (number1 + number2));
                        Console.ReadLine();
                    }
                    else if (simvol == "2")
                    {
                        Console.WriteLine("---");
                        Console.WriteLine("Разность ваших чисел = " + (number1 - number2));
                        Console.ReadLine();
                    }
                    else if (simvol == "3")
                    {
                        if (number2 == 0)
                        {
                            Console.WriteLine("---");
                            Console.WriteLine("Деление на ноль невозможно!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("---");
                            Console.WriteLine("Результат деления ваших чисел = " + (number1 / number2));
                            Console.ReadLine();
                        }
                    }
                    else if (simvol == "4")
                    {
                        Console.WriteLine("---");
                        Console.WriteLine("Произведение ваших чисел = " + (number1 * number2));
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Вы ввели некоректное значение");
                    Console.ReadLine();
                }
            }        
        }
    }
}
