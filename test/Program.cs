using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int i = int.Parse(Console.ReadLine());

            for (; i > 0; i--)
            {
                Console.WriteLine("до взрыва устройства осталось " + i + "мс");
            }
            Console.WriteLine("Бум!");
            Console.ReadLine();
        }
    }
}
