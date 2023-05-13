using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    // Что будет выведено на консоль в результате выполнения следующей программы и почему?:
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person { Name = "Tom" };
            Employee empl = tom as Employee;
            tom.Name = "Bob";
            Console.WriteLine(empl.Name);
            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
    class Employee : Person { }
}
