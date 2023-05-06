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
            DateTime datetime = DateTime.Now;

            datetime.Print();
            Console.WriteLine(datetime.DataTimeToDie());
            bool day = datetime.IsDateOfWeek(DayOfWeek.Saturday);

            string what = PrintIs(day);
            Console.WriteLine(what);
        }
        public static string PrintIs(bool day)
        {
            if (day != true) { string notDay = "it is not now day "; return notDay; }
            else { string thisDay = "it is now day"; return thisDay; }
        }
    }
}
