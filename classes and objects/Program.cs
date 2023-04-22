using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company apple = new Company();

            string applePhone = apple.Phone;
            int appleAge = apple.Age;

            apple.Age = 2001;
            apple.Phone = "Iphone";

            apple.Print();

        }
    }

    class Company
    {
        public string Phone = "None";
        public int Age;

        public void Print()
        {
            Console.WriteLine($"Марка телефона: {Phone}\t| Год сборки: {Age}");
        }
    }
}
