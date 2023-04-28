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
        static User InfoUserLenar()
        {
            User user = new User()
            {
                Nickname = "Ленар",
                Firstname = "Касимов",
                Age = 12,
                Account = "kasimovlenar2010@gmail.com",
                Phone = "+7 937 841-47-28"
            };
            return user;
        }
        static User InfoUserTimerlan()
        {
            User user = new User()
            {
                Nickname = "Тимерлан",
                Firstname = "Касимов",
                Age = 12,
                Account = null,
                Phone = null
            };
            return user;
        }
        static void Main(string[] args)
        {
            var Lenar = InfoUserLenar();
            Lenar.Print();

            string nameLenar = Lenar.PrintName();
            Console.WriteLine(nameLenar);

            var Timerlan = InfoUserTimerlan();
            Timerlan.Print();

        }   
    }
}
