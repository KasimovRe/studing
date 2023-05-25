using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanieYavnayaTipizacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoingSomething what1 = new DoingSomething(); 
            object obj = what1;
            object noObj = 14;

            if(obj is DoingSomething what2)
            {
                PrintI1(what2);
                PrintI2(what2);
            }

            Console.WriteLine();

            PrintI1((DoingSomething)obj);
            PrintI2((DoingSomething)obj);

            Console.WriteLine();

            if (noObj.Equals(what1))
            {
                Console.WriteLine("True");
            }
            Console.ReadKey();
        }

        static void PrintI1(IParent1 parent1)
        {
            parent1.Move();
        }
        static void PrintI2(IParent2 parent2)
        {
            parent2.Move();
        }
    }
    

}
