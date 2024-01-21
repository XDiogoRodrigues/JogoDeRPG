using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgConsole.Entities.GameCharacters
{
    abstract class Character
    {
        public string Name { get; private set; }
        public int Lv { get; private set; }
        public int Hp { get; private set; }
        public int Mp { get; private set; }
        public int Strength { get; private set; }
        public int AttackPower { get; private set; }
        public int MagicPower {get; private set;}
        public Weapon CharacterWeapon { get; private set; }

        public Character(string name, int lv, int hp, int mp, int strength, int attackPower, int magicPower)
        {
            Name = name;
            Lv = lv;
            Hp = hp;
            Mp = mp;
            Strength = strength;
            AttackPower = attackPower;
            MagicPower = magicPower;
        }
    }
}
