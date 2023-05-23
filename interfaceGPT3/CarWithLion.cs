using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceGPT3
{
    // Реализует IAnimalVehicle
    // Имеет внутри себя объекты Lion и Car
    // Перенаправляет вызовы методов на вложенные объекты.
    internal class CarWithLion : IAnimalVehicle
    {
        readonly Lion lion = new Lion();
        readonly Car car = new Car();

        public void Drive()
        {
            Console.WriteLine("Машина со львом выехала");
        }

        public void Hunt()
        {
            Console.Write("В машине. ");
            lion.Hunt();
        }

        public void MakeNoise()
        {
            Console.Write("Из машины. ");
            lion.MakeNoise();
        }

        public void Move()
        {
            car.Move();
        }

        public void StartEngine()
        {
            car.StartEngine();
        }
    }
}
