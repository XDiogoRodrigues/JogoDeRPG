using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgConsole.Entities.Weapons;
using RpgConsole.Entities.Armour;
using RpgConsole.Entities.Magics;

namespace RpgConsole.Entities.GameCharacters
{
    class Player: Character
    {
        public int NextLv { get; private set; }
        public int Exp { get; set; }
        public List<BlackMagic> listBlackMagic = new List<BlackMagic>();
        public List<WhiteMagic> listWhiteMagic = new List<WhiteMagic>();

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
            MagicPower = weapon.MagicPower;
            Mp = weapon.ManaBonus;                  
        }

        public void EquiArmor(Armor armor)
        {
            CharacterArmor = armor;
            Defense = armor.Defense;
        }

        public void UseMagicWhite()
        {

        }

        public void UseMagicBlack()
        {

        }

        public string Information()
        {
            StringBuilder s1 = new StringBuilder();
            s1.AppendLine($"LV: {Lv}");
            s1.AppendLine($"Name: {Name}");
            s1.AppendLine($"HP: {Hp}");
            s1.AppendLine($"MP: {Mp}");
            s1.AppendLine($"Strength: {Strength}");
            s1.AppendLine($"Attack Power: {AttackPower}");
            s1.AppendLine($"Magic Power: {MagicPower}");
            s1.AppendLine($"Defense: {Defense}");
            return s1.ToString();
        }



    }
}
