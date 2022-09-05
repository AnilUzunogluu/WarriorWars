using System;
using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    public class Warrior
    {
        private readonly Faction FACTION;

        private const float GOOD_GUY_STARTING_HEALTH = 20;
        private  const float BAD_GUY_SARTING_HEALTH = 40;
        
        
        private string name;
        private float health;
        private bool isAlive;

        public bool IsAlive
        {
            get { return isAlive; }
        }

        private Armor armor;
        private Weapon weapon;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.Good:
                    armor = new Armor(faction);
                    weapon = new Weapon(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.Bad:
                    armor = new Armor(faction);
                    weapon = new Weapon(faction);
                    health = BAD_GUY_SARTING_HEALTH;
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            float damage = weapon.Damage / enemy.armor.ArmorPoints;

            enemy.health -= damage;
            Utilities.AttackResult(name, enemy.name, damage, enemy.health);

            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Utilities.ColoredWriteLine($"{enemy.name} is dead.", ConsoleColor.Red);
                Utilities.ColoredWriteLine($"{name} is victorious.", ConsoleColor.Green);
            }
        }
    }
}