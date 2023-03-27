using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace stud3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum;

            Console.WriteLine("Ведите любое число для проверки на четность");
            number = int.Parse(Console.ReadLine());

            sum = number % 2;

            if (sum == 0)
            {
                Console.WriteLine("Ваше число четное");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ваше число нечетное");
                Console.ReadLine();
            }
        }
    }
}
