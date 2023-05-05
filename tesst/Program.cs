using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.Now;

            a.Print();
            Console.WriteLine(a.DataTimeToDie());
            bool day = a.IsDateOfWeek(DayOfWeek.Friday);

            string what = Printis(day);

            Console.WriteLine(what);
        }
        public static string Printis(bool day)
        {
            if (day != true) { string notDay = "it is not day now"; return notDay; }
            else { string thisDay = "it is day now"; return thisDay; }
        }
    }

    static class extension
    {
        public static void Print (this DateTime dateTime)
        {
            Console.WriteLine(dateTime.ToString());
        }
        public static string DataTimeToDie(this DateTime dateTime)
        {
            dateTime = DateTime.Parse("13.07.22 0:10:15");

            return dateTime.ToString();
        }
        public static bool IsDateOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }
    }
}
