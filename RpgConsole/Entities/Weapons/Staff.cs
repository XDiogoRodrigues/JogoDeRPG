using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgConsole.Entities.Weapons
{
    class Staff: Weapon
    {      

        public Staff(string category, string name, int attack, int magicPower, string element, int manaBonus) :base(category, name, attack, magicPower, element, manaBonus)
        {
            
        }
    }
}
