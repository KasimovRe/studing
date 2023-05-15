using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base derivedAsBase = new Derived();

            derivedAsBase.First();  // Derived.First(), выведет "First from Derived"                
            derivedAsBase.Second(); // Base.Second(), выведет "Second from Base"

            Console.ReadLine();
        }
    }

    class Base
    {
        public virtual void First()
        {
            Console.WriteLine("First from Base");
        }

        public void Second()
        {
            Console.WriteLine("Second from Base");
        }
    }

    class Derived : Base
    {
        public override void First()
        {
            Console.WriteLine("First from Derived");
        }

        public new void Second()
        {
            Console.WriteLine("Second from Derived");
        }
    }
}
