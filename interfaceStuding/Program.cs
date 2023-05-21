using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceStuding
{
    class Program
    {
        interface IHumanBehavior
        {
            string Name { get; set; }
            void Hello();
        }
        interface IALienBehavior
        {
            string Name { get; set; }
            void Destroy();
        }
        class Human : IHumanBehavior
        {
            string nameHuman;
            public string Name { get => nameHuman; set => nameHuman = value; }
            public void Hello()
            {
                Console.WriteLine("Человек говорит: Привет.");
            }
        }
        class Child : IHumanBehavior
        {
            string nameChild;
            public string Name { get => nameChild; set => nameChild = value; }
            public void Hello()
            {
                Console.WriteLine("Ребенок говорит: Привет.");
            }
        }
        class Alien : IALienBehavior
        {
            string nameAlien;
            public string Name { get => nameAlien; set => nameAlien = value; }
            public void Destroy()
            {
                Console.WriteLine("Чужой начинает уничтожение.");
            }
        }
        class Turrel
        {
            public void WhoIsThis(object unknownObject)
            {
                if (unknownObject is IHumanBehavior)
                {
                    SkipObject(unknownObject as IHumanBehavior);
                }
                else if (unknownObject is IALienBehavior)
                {
                    DestroyObject(unknownObject as IALienBehavior);
                }
            }
            private void DestroyObject(IALienBehavior alien)
            {
                Console.WriteLine("Он реализует инопланетные интерфейсы! Это " + alien.Name + ", поэтому он будет уничтожен!");
            }
            private void SkipObject(IHumanBehavior humanOrChild)
            {
                Console.WriteLine(humanOrChild.Name + " - " + humanOrChild.GetType().Name + " - реализует человеческое поведение, поэтому он может пройти.");
            }
        }
        static void Main(string[] args)
        {
            Human karlo = new Human();
            karlo.Name = "Карло";
            Child child = new Child();
            child.Name = "Буратино";
            Alien alien = new Alien();
            alien.Name = "Чужой";
            Turrel turrel = new Turrel();
            turrel.WhoIsThis(karlo);
            turrel.WhoIsThis(child);
            turrel.WhoIsThis(alien);
            Console.ReadKey();
        }
    }
}
