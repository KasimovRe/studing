using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie
{
    // Дана коллекция объектов неопределенного типа.
    // Определите тип каждого объекта и обработайте соответственно:
    class itisas
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal2();

            Animal2 animal2 = animal as Animal2;

            Animal animal3 = animal;
            animal3 = null;

            object[] obj = { 124, animal, animal2, animal3 };
            What(obj);
        }

        static void What(object[] obj)
        {
            foreach (var item in obj)
            {
                if (item is Animal animal) { Console.WriteLine("its animal"); }
                else if (item is Animal2 animal2) { Console.WriteLine( "its animal2" ); }
                else if ( item != null ) { Console.WriteLine("its not null"); }
                else { Console.WriteLine("WTF"); }
            }
        }
    }

    class Animal { }
    class Animal2 : Animal { }
}
