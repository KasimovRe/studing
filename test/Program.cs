using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test
// написать код, где мы указываем данные о человеке в класс, а затем передаем в другой и через него же выводим
// если значений нет, то значения дефолтные
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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Lenar lenar = new Lenar(); // здесь мы создаем объекты класса Ленар, где хранятся значения Ленара

            User danielUser = new User(Guid.NewGuid(), "Даниель", "Афанасьев", 10, null, null);
            User lenarUser = new User(lenar); // здесь мы создаем объект класса User, куда передаем значения объекта ленар т.е. его данные
            User timerlanUser = new User();
            User vladikUser = new User(lenar) // тут те же данные Ленара, только некоторые мы изменили
            {
                Id = Guid.NewGuid(),
                Nickname = "Владлен",
                Age = 17,
                Account = "None",
                Phone = "+7 (937) 788-80-90"
            };

            danielUser.Print();
            lenarUser.Print();
            timerlanUser.Print();
            vladikUser.Print();
        }
    }

    class Lenar // хранит значение пользователя Ленар
    {
        public Guid Id = Guid.NewGuid();
        public string Nickname = "Ленар";
        public string Firstname = "Касимов";
        public int Age = 12;
        public string Account = "kasimovlenar2010@gamil.com";
        public string Phone = "+7 (937) 841-47-28";
    }
}
