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
            Animal animal = new Animal();
            animal.PrintInfo();
            
            Cat cat = new Cat();
            cat.PrintInfo();
        }
    }

    public class Animal
    {
        public void PrintInfo()
        {
            Console.WriteLine("This is general animal info");
        }
    }

    public class Cat : Animal
    {
        public new void PrintInfo()
        {
            Console.WriteLine();
            base.PrintInfo();
            Console.WriteLine("This is cat specific info");
        }
    }
}
