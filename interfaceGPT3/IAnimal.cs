using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceGPT3
{
    // Определить интерфейс IAnimal с методом MakeNoise().
    // Внутри IAnimal определить вложенный интерфейс ICarnivore с методом Hunt().
    internal interface IAnimal
    {
        void MakeNoise();
    }

    internal interface ICarnivore : IAnimal
    {
        void Hunt();
    }

}
