using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceGPT3
{
    // Реализовать класс Car, который:
    // Реализует IVehicle
    // Реализует ICar(вложенный интерфейс IVehicle)
    // Переопределяет все методы.
    internal class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Машина начала движение. Водитель УБЕР скоро прибудет");
        }

        public void Move()
        {
            Console.WriteLine("Машина уже едет. Со скростью 80 км/ч");
        }

        public void StartEngine()
        {
            Console.WriteLine("Двигатель запущен");
        }
    }
}
