using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    // Создайте класс Employee с именем и зарплатой.
    // Создайте класс Contractor наследующийся от Employee.
    // Добавьте метод для преобразования Employee в Contractor.
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Бодя", 23500);

            Contractor contractor = new Contractor("opdfgfip", 34000);
            employee.ConvertToContractor(contractor);

            contractor.Print(employee);
        }
    }

    class Employee
    {
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public int Salary { get; set; }

        public Contractor ConvertToContractor(Contractor contractor)
        {
            if (contractor is Employee)
            {
                Employee employee = contractor;
                return (Contractor)employee;
            }
            return null;

        }
    }


    class Contractor : Employee
    {
        public Contractor(string name, int salary) : base(name, salary) { }

        public Employee ConvertToEmpoyee(Employee employee)
        {
            if (employee is Contractor contractor)
            {
                return contractor;
            }
            return null;
        }
        public void Print(Employee employee)
        {
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Salary);
        }
    }
}

