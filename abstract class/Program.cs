using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport car = new Car("машина");
            Transport ship = new Ship("корабль");
            Transport aircraft = new Aircraft("самолет");

            car.Move();         // машина движется
            ship.Move();        // корабль движется
            aircraft.Move();    // самолет движется
        }
    abstract class Transport
        {
            public string Name { get; }
            // конструктор абстрактного класса Transport
            public Transport(string name)
            {
                Name = name;
            }
            public void Move() => Console.WriteLine($"{Name} движется");

        }
        // класс корабля
        class Ship : Transport
        {
            // вызываем конструктор базового класса
            public Ship(string name) : base(name) { }
        }
        // класс самолета
        class Aircraft : Transport
        {
            public Aircraft(string name) : base(name) { }
        }
        // класс машины
        class Car : Transport
        {
            public Car(string name) : base(name) { }
        }
    }
}
