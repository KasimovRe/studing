using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    // Создайте класс Employee с именем и зарплатой.
    // Создайте класс Contractor наследующийся от Employee.
    // Добавьте метод для преобразования Employee в Contractor.
    class Program
    {
        static void Main(string[] args)
        {
            Dog rex = new Dog();
            rex.AnimalInfo = new Animal() { Name = "Rex" };
            rex.Age = 3;
            rex.Breed = "Labrador";

            rex.Print();
        }
    }

    struct Animal
    {
        public string Name;

        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    struct Dog
    {
        public Animal AnimalInfo;
        public int Age;
        public string Breed;

        public void Print()
        {
            AnimalInfo.Print();
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Breed: {Breed}");
        }
    }

    struct Cat
    {
        public Animal AnimalInfo;
        public int Age;
        public string Breed;

        public void Print()
        {
            AnimalInfo.Print();
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Breed: {Breed}");
        }
    }
}

