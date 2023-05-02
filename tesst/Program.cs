using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class IntNumber
    {
        private int d;

        public IntNumber(int _d) {d = _d;}

        public int Number
        { 
            get {return d;}
            set { d = value;}
        }

        public void Display() { Console.WriteLine("d = {0}", d); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // объявить экземпляр с именем number класса IntNumber
            IntNumber number = new IntNumber(5);

            // вывести значение внутренней переменной d
            number.Display(); // d = 5

            // изменить значение d через свойство Number.set
            number.Number = 25;
            number.Display(); // d = 25

            // использовать свойство Number.get для чтения d
            int t;
            t = number.Number; // t = 25
            Console.WriteLine("t = {0}", t);
        }
    }
}
