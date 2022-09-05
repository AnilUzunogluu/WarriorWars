using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    public class Weapon
    {
        private const float GOOD_GUY_DAMAGE = 10;
        private const float BAD_GUY_DAMAGE = 5;
        
        private float damage;

        public float Damage
        {
            get { return damage; }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.Good:
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.Bad:
                    damage = BAD_GUY_DAMAGE;
                    break;
            }
        }
    }
}