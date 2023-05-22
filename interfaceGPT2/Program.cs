using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfdaceGPT2
{
    internal class Program
    {
        // Интерфейс IWeapon - описывает поведение оружия.
        // Интерфейс ICharacter - описывает поведение персонажа.У него есть оружие - IWeapon.

        // У нас есть два класса:
        // Warrior(рыцарь) - реализует ICharacter
        // Sword(меч) - реализует IWeapon

        // То есть, рыцарь является персонажем и имеет оружие - меч.

        static void Main(string[] args)
        {
            Sword sword = new Sword();
            Warrior warrior = new Warrior();
            warrior.Weapon = sword;

            warrior.Attack(); // Со свистом разя мечом!

            Gun gun = new Gun();
            warrior.Weapon = gun;
            warrior.Attack();

            Console.ReadKey();
        }
    }
    interface IWeapon
    {
        void AttackWeapon(); // метод атака. его должен реализовывать каждый объект оружия
    }
    interface ICharacter
    {
        void Attack(); // отдельный метод атаки уже для человека
        IWeapon Weapon { get; set; } // используя тип интерфейса оружия, мы передаем в него значение
                                     // какой меч выбираем. то есть для этого изначально нужно объявить 
                                     // объект класс Sword от IWeapon
    }

    /////////////////////////
    
    class Warrior : ICharacter // реализуем интерфейс ЧАРАКТЕР. там 1 метод и 1 свойство типа интерфейса ВИАПОН
    {
        public IWeapon Weapon { get; set; } // обязательно передаем значение меча, от интерфейса
                                            // ВИАПОН и соответствующего класса

        public void Attack()
        {
            Weapon.AttackWeapon(); // так как объект ВИАПОН унаследован от интерфейса, то при вызове
                                   // метода АТАК черещ оружие, он вызывет его от класса объекта от
                                   // интерфейса
        }
    }

    class Sword : IWeapon // по лайту. просто создаем меч от иетерфейса и выдаем ему метод атаки
    {
        public void AttackWeapon()
        {
            Console.WriteLine("Со свистом разя мечом!");
        }
    }

    class Gun : IWeapon
    {
        public void AttackWeapon()
        {
            Console.WriteLine("Пиу-пиу");
        }
    }
}
