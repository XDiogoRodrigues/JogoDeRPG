using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgConsole.Entities.Weapons;
using RpgConsole.Entities.Armour;

namespace RpgConsole.Entities.GameCharacters
{
    class Player: Character
    {
        public int NextLv { get; private set; }
        public int Exp { get; set; }

        public Player(string name, int lv, int hp, int mp, int strength, int attackPower, int magicPower, int defense) : base(name, lv, hp, mp, strength, attackPower, magicPower, defense)
        {
            NextLv = 120;
        }

        public void ModifiedNextLv()
        {
            NextLv += 80;
        }

        public void EquiWeapon(Weapon weapon)
        {
            CharacterWeapon = weapon;
            AttackPower = weapon.Attack;
        }

        public void EquiArmor(Armor armor)
        {
            CharacterArmor = armor;
            Defense = armor.Defense;
        }

    }
}
