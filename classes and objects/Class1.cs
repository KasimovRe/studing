using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    internal class User
    {
        public Guid id = Guid.NewGuid();
        public string Nickname = "No name";
        public string Firstname = "No firstname";
        public int Age;
        public string Account = "Not";
        public string Phone;

        public void Print()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"ID: {id}");
            Console.Write($"Имя: {Nickname} | ");
            Console.WriteLine($"Фамилия: {Firstname}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Почта: {Account}");
            Console.WriteLine($"Телефон: {Phone}");
            Console.WriteLine("----------------------------\n");
        }

        public string PrintName() { return $"Имя: {Nickname} | Фамилия: {Firstname}"; }
    }
}
