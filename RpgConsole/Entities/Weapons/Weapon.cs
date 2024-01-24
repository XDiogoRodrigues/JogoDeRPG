using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgConsole.Entities.Weapons
{
    abstract class Weapon
    {
        public string Category { get;}
        public string Name { get;}
        public int Attack { get; private set; }
        public int MagicPower { get; private set; }
        public string Element { get;}
        public int ManaBonus { get; }

        public Weapon(string category, string name, int attack, int magicPower, string element, int manaBonus)
        {
            Category = category;
            Name = name;
            Attack = attack;
            MagicPower = magicPower;
            Element = element;
            ManaBonus = manaBonus;
        }

        public override string ToString()
        {
            return $"Category: {Category}\nName: {Name}\nAttack: {Attack}\nMagicPower: {MagicPower}\nElement: {Element}\nMana Bonus: {ManaBonus}";
        }

    }
}
