using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgConsole.Entities.GameCharacters
{
    class Enemy: Character
    {
        public string Weak { get;}
        public int Exp { get;}

        public Enemy(string name, int lv, int hp, int mp, int strength, int attackPower, int magicPower, int defense, string weak, int exp) : base(name, lv, hp, mp, strength, attackPower, magicPower, defense)
        {
            Weak = weak;
            Exp = exp;
        }

    }
}
