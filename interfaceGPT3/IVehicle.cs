using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceGPT3
{
    // Определить интерфейс IVehicle с методом Move().
    // Внутри IVehicle определить интерфейс ICar с методами StartEngine() и Drive().

    internal interface IVehicle
    {
        void Move();
    }

     internal interface ICar : IVehicle
    {
        void Drive();

        void StartEngine();
    }
}
