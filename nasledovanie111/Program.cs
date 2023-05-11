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
            ParentsMe parents = new ParentsMe()
            {};

            Vladlen vladlen = new Vladlen()
            {
                Son = "Владлен",
                GirlSons = "Лиза",

                Mother = "Катя",
                Father = "Ильшат"
            };

            vladlen.Info();

            Console.WriteLine("\n");
            ParentsLisa parentsLisa = new ParentsLisa()
            {
                Mother = "Nеизвестно",
            };

            parentsLisa.Info1();

            Class1 class1 = new Class1();
            class1.Buga();
        }

    }
    class ParentsMe 
    {
        private string mother;
        public string Mother { get { return mother; } set { mother = value; } }
        public string Father { get; set; }

        public void Info1()
        {
            Console.WriteLine(mother);
            Console.WriteLine(Father);
        }
    }
    class ParentsLisa : ParentsMe
    {
    }
    class Vladlen : ParentsMe
    {
        public string Son { get; set; }
        public string GirlSons { get; set; }

        public void Info()
        {
            Console.WriteLine(Son);
            Console.WriteLine(GirlSons);

            ParentsLisa parent = new ParentsLisa() { Mother = "Nеизвестно" };
            parent.Info1();
            Info1();
        }
    }

    class Lenar : ParentsMe
    {
        public string Son { get; set;}
        public string GirlSons { get; set; }

        public void Info()
        {
            Console.WriteLine(Son);
            Console.WriteLine(GirlSons);
        }
    }
}
