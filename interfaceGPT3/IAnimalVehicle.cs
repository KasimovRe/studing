using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceGPT3
{
    // Определить интерфейс IAnimalVehicle, наследующий от IAnimal и IVehicle.
    internal interface IAnimalVehicle : ICarnivore, ICar
    {
    }
}
