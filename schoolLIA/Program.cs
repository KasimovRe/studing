using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolLIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint a = Convert.ToUInt32(Console.ReadLine());
            int b = 10;
            int c = 98;
            int x = (int)(a * b * c) / 2;
            Console.WriteLine(x);

            bool sum = (a < b) && (b < c);

            Console.WriteLine(sum);

        }
    }
}
