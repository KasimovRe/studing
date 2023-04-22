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
            User Lenar = new User();

            string nicknameLenar = Lenar.Nickname;
            string accountLenar = Lenar.Account;

            Lenar.Nickname = "Абобус";
            Lenar.Account = "kasimovlenar2010@gmail.com";

            Lenar.Info();
            Lenar.Data(02, 10, 2010);
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

    class Family
    {
        public string Mother = "Not";
        public string Father = "Not";
        public string Brother = "Not";
        public string Sister = "Not";
        public string GrandMother = "Not";
        public string GrandFather = "Not";
    }
}
