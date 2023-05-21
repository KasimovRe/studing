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
        }
    }
    interface IWeapon
    {
        void Attack();
    }
    interface ICharacter
    {
        IWeapon Weapon { get; set; } // объявляем свойство интерфейса IWeapon
    }

    class Warrior : ICharacter
    {
        public IWeapon Weapon { get; set; }


    }
}
