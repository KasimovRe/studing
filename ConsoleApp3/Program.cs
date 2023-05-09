using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    // Создайте расширение для типа DateTime, которое будет возвращать количество лет между текущей датой и заданной датой.
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTimeSet = DateTime.Parse("8.5.1945");

            Console.WriteLine(dateTimeSet.DateTimeReturnAge());
        }
    }

    static class ExtensionDateTime
    {
        public static int DateTimeReturnAge(this DateTime dateTime)
        {
            var ageNow = DateTime.Now;
            var age = ageNow.Year - dateTime.Year;
            if (dateTime.Year + age > ageNow.Year) { age--; }
            return age;
        }
    }

}
