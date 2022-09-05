using System;
using System.Threading;
using WarriorWars.Enum;

namespace WarriorWars
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            Warrior goodGuy = new Warrior("Obi-Wan Kenobi", Faction.Good);
            Warrior badGuy = new Warrior("Darth-Vader", Faction.Bad);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (random.Next(0,10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                        badGuy.Attack(goodGuy);
                }
                
                Thread.Sleep(250);
            }
            
        }
    }
}