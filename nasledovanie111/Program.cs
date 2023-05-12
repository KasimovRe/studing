using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie111
    // создать класс, допустим, который ну будет иметь родительский класс Parents и
    // будет выводить на консоль имена членов семьи. а далее дочерние которые ну тд короч пон
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ParentsMe parents = new ParentsMe()
    //        {};

    //        Vladlen vladlen = new Vladlen()
    //        {
    //            Son = "Владлен",
    //            GirlSons = "Лиза",

    //            Mother = "Катя",
    //            Father = "Ильшат"
    //        };

    //        vladlen.Info1();

    //        Console.WriteLine("\n");
    //        ParentsLisa parentsLisa = new ParentsLisa()
    //        {
    //            Mother = "Nеизвестно",
    //        };

    //        parentsLisa.Info();

    //        Class1 class1 = new Class1();
    //        class1.Buga();
    //    }

    //}
    //class ParentsMe 
    //{
    //    private string mother;
    //    public string Mother { get { return mother; } set { mother = value; } }
    //    public string Father { get; set; }

    //    public void Info()
    //    {
    //        Console.WriteLine(mother);
    //        Console.WriteLine(Father);
    //    }
    //}
    //class ParentsLisa : ParentsMe
    //{
    //}
    //class Vladlen : ParentsMe
    //{
    //    public string Son { get; set; }
    //    public string GirlSons { get; set; }

    //    public void Info1()
    //    {
    //        Console.WriteLine(Son);
    //        Console.WriteLine(GirlSons);

    //        ParentsLisa parent = new ParentsLisa() { Mother = "Nеизвестно" };
    //        parent.Info();
    //        base.Info();
    //    }
    //}

    //class Lenar : ParentsMe
    //{
    //    public string Son { get; set;}
    //    public string GirlSons { get; set; }

    //    public void Info()
    //    {
    //        Console.WriteLine(Son);
    //        Console.WriteLine(GirlSons);
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Parents lisa = new Parents()
            {
                Mom = "Кто-то",
            };

            Family me = new Family()
            {
                Mom = "Мама",
                Pap = "Папа",
                GirlSons = "Лиза"
            };


            Family pap = new Family() { GirlSons = "Лиза", Son = "Владик" };

            lisa.Print();
            me.Print();
            pap.Print();

            Relative lenar = new Relative()
            {
                Brother = Family.me,
                GirlSons = me.GirlSons,
                Mom = me.Mom, 
                Pap = me.Pap,
            };

            lenar.Print();
        }
    }

    class Parents
    {
        public string Mom { get; set; }
        public string Pap { get; set; }

        public Parents() 
        {
            Console.WriteLine("Вызыван базовый метод вызова родителей");
        }

        public void Print()
        {
            Console.WriteLine("1----------------------");
            Console.WriteLine(Mom);
            Console.WriteLine(Pap);
            Console.WriteLine("----------------------1");
            Console.WriteLine();
        }
    }

    class Family : Parents
    {
        public static string me = "Владик";
        public Family()
        {
            Console.WriteLine("Вызыван метод вызова семьи");
        }
        public string Son { get; set; }
        public string GirlSons { get; set; }

        public new void Print()
        {
            Console.WriteLine("2----------------------");
            base.Print();
            Console.WriteLine(Son);
            Console.WriteLine(GirlSons);
            Console.WriteLine("----------------------2");
            Console.WriteLine();
        }
    }

    class Relative : Family
    {
        public Relative()
        {
            Console.WriteLine("Вызыван метод вызова родственника");
        }
        public string Brother { get { return Son ; } set { Son = value; } }

        public new void Print()
        {
            Console.WriteLine("3----------------------");
            base.Print();
            Console.WriteLine(Brother);
            Console.WriteLine("----------------------3");
            Console.WriteLine();
        }
    }
}
