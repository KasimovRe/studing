using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.Now;

            a.Print();
            Console.WriteLine(a.DataTimeToDie());
            bool day = a.IsDateOfWeek(DayOfWeek.Saturday);

            string what = PrintIs(day);
            Console.WriteLine(what);
        }
        public static string PrintIs(bool day)
        {
            if (day != true) { string notDay = "it is not day now"; return notDay; }
            else { string thisDay = "it is day now"; return thisDay; }
        }
    }
}
