using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    
    class User // Получает значения о человеке и выводит их на консоль
    {
        public Guid Id;
        public string Nickname;
        public string Firstname;
        public int Age;
        public string Account;
        public string Phone;

        public User()
        {
            Nickname = "No name";
            Firstname = "No firstname";
            Age = 0;
            Account = "None";
            Phone = "None";
        }

        public User(string nickname, string firstname)
        {
            Nickname = nickname ?? "нет данных";
            Firstname = firstname ?? "нет данных";
        }


        public User(Guid id, string nickname, string firstname, int age, string account, string phone) : this(nickname, firstname) 
        {
            Id = id;
            Age = age;
            Account = account ?? "нет данных";
            Phone = phone ?? "нет данных";
        }

        public User(Lenar lenar)
        {
            Id = lenar.Id;
            Nickname = lenar.Nickname ?? "нет данных";
            Firstname = lenar.Firstname ?? "нет данных";
            Age = lenar.Age;
            Account = lenar.Account ?? "нет данных";
            Phone = lenar.Phone ?? "нет данных";
        }

        public void Print()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"ID: {Id}");
            Console.Write($"Имя: {Nickname} | ");
            Console.WriteLine($"Фамилия: {Firstname}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Почта: {Account}");
            Console.WriteLine($"Телефон: {Phone}");
            Console.WriteLine("----------------------------\n");
        }

        public void PrintName()
        {
            Console.WriteLine("----------------------------");
            Console.Write($"Имя: {Nickname} | ");
            Console.WriteLine($"Фамилия: {Firstname}");
            Console.WriteLine("----------------------------\n");
        }
    }
}
