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
            int kolvo = 0;

            var i = 1;

            for (Console.WriteLine("Начало выполнения цикла"); i < 4; Console.WriteLine($"i = {i}"))
            {
                i++;
            }
        }
    }
}
