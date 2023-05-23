using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceGPT3
{
    // Определить интерфейс IAnimal с методом MakeNoise().
    // Внутри IAnimal определить вложенный интерфейс ICarnivore с методом Hunt().

    // Реализовать класс Lion, который:
    // Реализует IAnimal
    // Реализует ICarnivore(вложенный интерфейс IAnimal)
    // Переопределяет методы MakeNoise() и Hunt()
    // Определить интерфейс IVehicle с методом Move().
    // Внутри IVehicle определить интерфейс ICar с методами StartEngine() и Drive().

    // Реализовать класс Car, который:
    // Реализует IVehicle
    // Реализует ICar(вложенный интерфейс IVehicle)
    // Переопределяет все методы.
    // Определить интерфейс IAnimalVehicle, наследующий от IAnimal и IVehicle.

    // Реализовать класс CarWithLion, который:

    // Реализует IAnimalVehicle
    // Имеет внутри себя объекты Lion и Car
    // Перенаправляет вызовы методов на вложенные объекты.

    internal class Program
    {
        static void Main(string[] args)
        {
            CarWithLion carLion = new CarWithLion();

            carLion.MakeNoise();
            carLion.Hunt();
            carLion.Drive();

            Lion lion = new Lion();
            lion.MakeNoise();

            Console.ReadKey();
        }
    }
    
}
