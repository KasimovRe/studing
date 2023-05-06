using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static class ExtensionDay
    {
        public static void Print(this DateTime daytime) => Console.WriteLine(daytime);
        public static string DataTimeToDie(this DateTime dateTime)
        {
            dateTime = DateTime.Parse("13.07.22 0:10:15");

            return dateTime.ToString();
        }
        public static bool IsDateOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            Console.Write($"День {dayOfWeek}: ");
            return dateTime.DayOfWeek == dayOfWeek;
        }
    }
}
