using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgConsole.Entities.Weapons
{
    class Weapon
    {
        public string Category { get;}
        public string Name { get;}
        public int Refine { get; private set; }
        public int Attack { get; private set; }
        public string Element { get;}

        public Weapon(string category, string name, int attack, string element)
        {
            Category = category;
            Name = name;
            Attack = attack;
            Element = element;
        }
    }
}
