using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace const_readonly
{
    // Определить класс Car с полями:

    // константа string Model
    // константа int EngineSize
    // константа bool IsElectric
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Info();
        }
    }

    class Car
    {
        static Car() 
        {
            Console.Write("write '0' if car is | electric |, else write '1'\nNumber of car is: ");

            int electric = int.Parse(Console.ReadLine());

            if (electric == 0) IS_ELECTRIC = true;
            else if (electric == 1) IS_ELECTRIC = false;
            else { IS_ELECTRIC = false; Console.WriteLine($"Incorrection value. Auto: {IS_ELECTRIC} = false"); }
        }

        public const string MODEL = "Lada";
        public const int ENGINE_SIZE = 1390;
        static readonly bool IS_ELECTRIC;

        public void Info()
        {
            Console.WriteLine(MODEL);
            Console.WriteLine(ENGINE_SIZE);
            
            if (IS_ELECTRIC == true) { Console.WriteLine("This car electric"); }
            else { Console.WriteLine("This car NOT electric"); }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
