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
                Nickname = Console.ReadLine(),
                Firstname = "Касимов",
                Age = 12,
                Account = "kasimovlenar2010@gmail.com",
                Phone = "+7 937 841-47-28"
            };
            return Lenar;
        }

        static void Main(string[] args)
        {
            var Lenar = InfoUser();
            Lenar.Print();

            var Timerlan = InfoUser();
            Timerlan.Print();

            string nameTim = Lenar.PrintName();
            Console.WriteLine(nameTim);
        }
    }
}
