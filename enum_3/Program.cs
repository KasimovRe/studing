using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_3
{
    internal class Program
    {
        // Создать перечисление "Операции"
        // написать метод, который принимает два числа и операцию, выполняет ее и возвращает результат
        static void Main(string[] args)
        {
            int choice = 4;

            double number1 = 10;
            double number2 = 123;

            Operation operation = (Operation)choice;

            Console.WriteLine(Calculator(operation, number1, number2));
        }

        enum Operation: byte { Addition = 1, Subtraction, Multiplication, Division }

        static double Calculator(Operation operation, double number1, double number2, double sum = 0)
        {
            switch (operation)
            {
                case Operation.Addition:
                     sum = (number1 + number2);
                    break;
                case Operation.Subtraction:
                     sum = (number1 - number2);
                    break;
                case Operation.Multiplication:
                     sum = (number1 * number2);
                    break;
                case Operation.Division:
                     sum = (number1 / number2);
                    break;
            }
            return sum;
        }
    }
}
