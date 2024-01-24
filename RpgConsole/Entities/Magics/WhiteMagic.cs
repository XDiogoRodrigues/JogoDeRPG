using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgConsole.Entities.Magics
{
    class WhiteMagic: Magic
    {
        public int EffectMagic { get; set; }

        public WhiteMagic(string typeMagic, string name, int costMana, int effectMagic):base(typeMagic, name, costMana)
        {
            EffectMagic = effectMagic;
        }
    }
}
