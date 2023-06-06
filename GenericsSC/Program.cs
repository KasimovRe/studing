using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9; int b = 10;  
            Console.WriteLine($"{a} | {b}");

            Task1(ref a, ref b);
            Console.WriteLine($"{a} | {b}");

            string aa = "Slava"; string bb = "USSR";
            Console.WriteLine($"{aa} | {bb}");

            Task2(ref aa, ref bb);
            Console.WriteLine($"{aa} | {bb}");

            int[] ints1 = new int[] { 1, 4, 7 };
            int[] ints2 = new int[] { 4, 7, 9 };

            Task1(ref ints1, ref ints2);

            object aaa = 123;
            object bbb = 0;

            Console.WriteLine(Task3(ref aaa, ref bbb));
            Console.Read();
        }

        static void Task1<T> (ref T a, ref T b)
        {
            (b, a) = (a, b);
        }
        static void Task2<T> (ref T a, ref T b)
        {
            T temp = a; 
            a = b; 
            b = temp;
        }
        static T Task3<T> (ref T a, ref T b)
        {
            (b, a) = (a, b);
            return a;
        }
    }
}
