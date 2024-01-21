using RpgConsole.Entities.GameCharacters;

namespace RpgConsole.Service
{
    class VerificationElement
    {
        public static bool Critical(Character Attacker, Character Target)
        {
            if(Attacker.CharacterWeapon.Element == Target.CharacterArmor.Weak)
            {
                return true;
            }
            return false;
        }
    }
}
