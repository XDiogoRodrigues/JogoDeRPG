using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgConsole.Entities.GameCharacters;

namespace RpgConsole.Service
{
    class DamageCalculator
    {
        private Character Attacker { get; }
        private Character Target { get; }

        public DamageCalculator(Character attacker, Character target)
        {
            Attacker = attacker;
            Target = target;
        }

        public void CalculateDamage()
        {
            if(VerificationElement.Critical(Attacker, Target))
            {
                int damageExtra = Attacker.Strength * 2;
                int damageTotal = (damageExtra + Attacker.AttackPower) * 2 ;

                Target.ModifiedHp(damageTotal - (Target.Defense + Target.Strength));

            }
            else
            {
                int damageExtra = Attacker.Strength * 2;
                int damageTotal = damageExtra + Attacker.AttackPower;

                Target.ModifiedHp(damageTotal - (Target.Defense + Target.Strength));
            }
          
        }
    }
}
