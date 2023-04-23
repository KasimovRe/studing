using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User Lenar = new User
            {
                Nickname = "Абобус",
                Account = "kasimovlenar2010@gmail.com"
            };

            Lenar.Info();
            Lenar.Data(02, 10, 2010);

            User Timerlan = new User("Бомжик", "kasimovtimerlan2009@gmail.com") { Nickname = "Кролик" };
            Person TImerlan = new Person("Бомж", 13)
            {
                name = "Жоп",
                age = 12
            };
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

    class User
    {
        public string Nickname = "No name";
        public string Account = "Not";

        public void Data(int day, int month, int year)
        {
            Console.WriteLine($"Дата рождения: {day}.{month}.{year}");
        }
        public void Info()
        {
            Console.WriteLine($"Имя: {Nickname}\tАккаунт: {Account}");
        }
    }

    class Person
    {
        public string name = "Sam";
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
