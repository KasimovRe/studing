using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var day in Enum.GetValues(typeof(DayOfWeek)))
                Console.Write($"{day} ");

            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            Console.WriteLine($"\n\nДень недели: {dayOfWeek}\tНомер в неделе: {DayOfWeekInNumber(dayOfWeek)} ");
        }

        enum DayOfWeek: byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static string DayOfWeekInNumber(DayOfWeek dayOfWeek)
        {
            string output = "";
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    output = "1";
                    break;
                case DayOfWeek.Tuesday:
                    output = "2";
                    break;
                case DayOfWeek.Wednesday:
                    output = "3";
                    break;
                case DayOfWeek.Thursday:
                    output = "4";
                    break;
                case DayOfWeek.Friday:
                    output = "5";
                    break;
                case DayOfWeek.Saturday:
                    output = "6";
                    break;
                case DayOfWeek.Sunday:
                    output = "7";
                    break;
            }
            return output;
        }
    }
}
