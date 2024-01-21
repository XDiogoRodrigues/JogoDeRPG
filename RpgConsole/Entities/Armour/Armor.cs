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
        public string Weak { get; }

        public Armor(string name, int defense, int magicDefense, string weak)
        {
            Name = name;
            Defense = defense;
            MagicDefense = magicDefense;
            Weak = weak;
        }
    }
}
