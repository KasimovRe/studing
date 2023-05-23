using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceGPT3
{
    // Реализовать класс Lion, который:
    // Реализует IAnimal
    // Реализует ICarnivore(вложенный интерфейс IAnimal)

    internal class Lion : ICarnivore
    {
        public void Hunt()
        {
            Console.WriteLine("Нападает на цель быстро и резко"); ;
        }

        public void MakeNoise()
        {
            Console.WriteLine("Мега рык"); ;
        }
    }
}
