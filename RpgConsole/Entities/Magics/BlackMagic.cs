using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgConsole.Entities.Magics
{
    class BlackMagic: Magic
    {
        public int DamageMagic { get; set; }
        public string ElementMagic { get; set; }

        public BlackMagic(string typeMagic, string name, int costMana, int damageMagic, string elementMagic):base(typeMagic, name, costMana)
        {

            DamageMagic = damageMagic;
            ElementMagic = elementMagic;
        }
    }
}
