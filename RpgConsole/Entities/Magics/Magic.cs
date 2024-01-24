using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgConsole.Entities.Magics
{
    abstract class Magic
    {
        public string TypeMagic { get; set; }
        public string Name { get; set; }
        public int CostMana { get; set; }

        public Magic(string typeMagic, string name, int costMana)
        {
            TypeMagic = typeMagic;
            Name = name;
            CostMana = costMana;
        }
    }
}
