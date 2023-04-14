using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 27349;
            Console.WriteLine(SumNumber(ref number));

        }

        static int SumNumber(ref int number, int sum = 0, int constant = 10)
        {
            if (number / constant < 10)
            {
                sum += (number % 10);
                sum += (number / constant);

                return 0;
            }

            sum += ((number / constant) % 10);
            constant *= 10;

            SumNumber(ref number, sum, constant);

            return sum+= sum;

        }
    }
}
