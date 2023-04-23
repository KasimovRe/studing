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

        static User InfoUser()
        {
            User Lenar = new User
            {
                Nickname = "Ленар",
                Firstname = "Касимов",
                Age = 12,
                Account = "kasimovlenar2010@gmail.com",
                Phone = 89378414728
            };
            return Lenar;
        }

        static void Print(User Lenar)
        {
            Console.WriteLine($"Имя: {Lenar.Nickname}");
            Console.WriteLine($"Фамилия: {Lenar.Firstname}");
            Console.WriteLine($"Возраст: {Lenar.Age}");
            Console.WriteLine($"Почта: {Lenar.Account}");
            Console.WriteLine($"Телефон: {Lenar.Phone}");
        }

        static void Main(string[] args)
        {
            var Lenar = InfoUser();
            Print(Lenar);
        }
    }

    class User
    {
        public string Nickname = "No name";
        public string Firstname = "No firstname";
        public int Age;
        public string Account = "Not"; 
        public long Phone;
    }
}
