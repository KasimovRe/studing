using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
// Создайте класс MathUtils, который будет содержать
// статическое поле pi и методы Add() и Multiply(),
// которые будут принимать два числа и возвращать их
// сумму и произведение, соответственно, умноженные на значение pi.
{
    class Program
    {
        static void Main(string[] args)
        {
            MathUtils math1 = new MathUtils() { Number_one = 16 };

            MathUtils.Number_two = 4;

            double sum;

            sum = MathUtils.Add();
            Console.WriteLine(sum);

            sum = MathUtils.Multiply();
            Console.WriteLine(sum);

            Console.WriteLine(math1.Number_one);
        }
    }
    class MathUtils
    {
        private static readonly double pi = 3.14;

        public int Number_one { get { return number_one; } set { number_one = value; } }
        private static int number_one;

        public static int Number_two { get { return number_two; } set { number_two = value; } }
        private static int number_two;

        public static double Add() { return (number_one + number_two) * pi; }

        public static double Multiply() { return number_one * number_two * pi; }
    }
}
