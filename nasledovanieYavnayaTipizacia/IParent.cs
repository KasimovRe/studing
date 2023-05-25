using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanieYavnayaTipizacia
{
    interface INaslednik : IParent1, IParent2 { }
    interface IParent1
    {
        void Move();
    }
    interface IParent2
    {
        void Move();
    }
}
