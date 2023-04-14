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
            int number = 279;
            SumNumber(ref number);

        }

        static void SumNumber(ref int number, int sum = 0, int constant = 10, int lastNumber = 0)
        {
            if (number / constant > 9)
            {
                lastNumber = number / constant;
            }
            

            
        }
    }
}
