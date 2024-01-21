using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgConsole.Entities.Armour
{
    class Armor
    {
        public string Name { get;}
        public int Defense { get;}
        public int MagicDefense { get; }

        public Armor(string name, int defense, int magicDefense)
        {
            Name = name;
            Defense = defense;
            MagicDefense = magicDefense;
        }
    }
}
