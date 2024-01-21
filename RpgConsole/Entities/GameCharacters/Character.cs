using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgConsole.Entities.Weapons;
using RpgConsole.Entities.Armour;
using RpgConsole.Service;

namespace RpgConsole.Entities.GameCharacters
{
     abstract class Character
    {
        public string Name { get; private set; }
        public int Lv { get; private set; }
        public int Hp { get; private set; }
        public int Mp { get; private set; }
        public int Strength { get; private set; }
        public int AttackPower { get; protected set; }
        public int MagicPower {get; protected set;}
        public int Defense { get; protected set; }
        public Weapon CharacterWeapon { get; protected set; }
        public Armor CharacterArmor { get; protected set; }

        public Character(string name, int lv, int hp, int mp, int strength, int attackPower, int magicPower, int defense)
        {
            Name = name;
            Lv = lv;
            Hp = hp;
            Mp = mp;
            Strength = strength;
            AttackPower = attackPower;
            MagicPower = magicPower;
            Defense = defense;
        }
        public void ModifiedLv(int lv)
        {
            Lv += lv;
            Hp += 80 * lv;
            Mp += 10 * lv;
            Strength += 1 * lv;
        }
        public void ModifiedHp(int damage)
        {
            Hp -= damage;
        }   

        public void ModifiedMp(int mp)
        {
            Mp -= mp;
        }  
        protected void AttackEnemy(Character enemy)
        {
            DamageCalculator Damage = new DamageCalculator(this, enemy);
            Damage.CalculateDamage();
        }
    }
}
