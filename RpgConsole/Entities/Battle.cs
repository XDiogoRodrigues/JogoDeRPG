using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgConsole.Entities.GameCharacters;

namespace RpgConsole.Entities
{
    class Battle
    {
        public Player GamePlayer { get; set; }
        public Enemy EnemyPlayer { get; set; }
    }
}
