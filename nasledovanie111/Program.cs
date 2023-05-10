using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie111
{
    // создать класс, допустим, который ну будет иметь родительский класс Parents и
    // будет выводить на консоль имена членов семьи. а далее дочерние которые ну тд короч пон
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Family
    {
        public string Mother { get; set; }
        public string Father { get; set; }

        public void PrintFamily()
        {
            Console.WriteLine(Mother);
            Console.WriteLine(Father);
        }
    }
    class Vlalden : Family
    {
        public string Son { get; set; }
        public string GirlSons { get; set; }

        public void PrintFamily() : this
        {

        }
    }
}
