using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseGPT
{
    // Создайте базовый класс Animal с полями name и age.
    // Затем создайте производный класс Cat. Используйте
    // base в конструкторе Cat, чтобы передать значения
    // name и age родительскому конструктору.
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Барсик", 6);
            cat.Print();


        }
    }

    class Animal
    {
        public Animal(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
        }
    }
}
