using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    public class Armor
    {
        private const float BAD_GUY_ARMOR = 5;
        private const float GOOD_GUY_ARMOR = 4;
        
        private float armorPoints;

        public float ArmorPoints
        {
            get { return armorPoints; }
        }
        
        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.Good:
                    armorPoints = GOOD_GUY_ARMOR;
                    break;
                case Faction.Bad:
                    armorPoints = BAD_GUY_ARMOR;
                    break;
            }
        }
    }
}