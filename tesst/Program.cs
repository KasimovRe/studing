using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
        }
        public void PrintCompany()
        {
            base.Print();
            Console.WriteLine(Company);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Саске");
            person.Print();

            Console.Write("\n");
            Employee employee = new Employee("Наруто", "Коноха");
            employee.PrintCompany();
        }
    }
}
