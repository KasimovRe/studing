using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rec_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint number = 5681;
            uint sum = 0;

            SumNumber(number, ref sum);
            Console.WriteLine(sum);
        }

        static uint SumNumber(uint number, ref uint sum, uint constant = 10)
        {
            if (number / constant < 9)
            {
                sum += (number % 10);
                sum += (number / constant);
                return sum;
            }

            sum += ((number / constant) % 10);
            constant *= 10;

            SumNumber(number, ref sum, constant);

            return sum;
        }
    }
}
