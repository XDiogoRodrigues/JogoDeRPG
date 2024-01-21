using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgConsole.Entities.Weapons;
using RpgConsole.Entities.Armour;

namespace RpgConsole.Entities.GameCharacters
{
    class Enemy: Character
    {
        public int Exp { get;}

        public Enemy(string name, int lv, int hp, int mp, int strength, int attackPower, int magicPower, int defense, int exp, Weapon weapon, Armor armor) : base(name, lv, hp, mp, strength, attackPower, magicPower, defense)
        {
            Exp = exp;
            CharacterWeapon = weapon;
            CharacterArmor = armor;
            AttackPower += weapon.Attack;

        }

    }
}
