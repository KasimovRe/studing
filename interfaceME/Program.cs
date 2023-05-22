using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceME
{
    // Интерфейс IWeapon - описывает поведение оружия.

    // Интерфейс ICharacter - описывает поведение персонажа.У него есть оружие - IWeapon.

    // У нас есть два класса:

    // Warrior(рыцарь) - реализует ICharacter
    // Sword(меч) - реализует IWeapon
    // То есть, рыцарь является персонажем и имеет оружие - меч.

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IWeapon
    {
        string Weapon { get; set; }
    }
    interface ICharacte
    {

    }
}
