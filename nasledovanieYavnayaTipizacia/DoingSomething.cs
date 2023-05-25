using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanieYavnayaTipizacia
{
    class DoingSomething : INaslednik
    {
        void IParent1.Move()
        {
            Console.WriteLine("IParent1");
        }

        void IParent2.Move()
        {
            Console.WriteLine("IParent2");
        }
    }
}
