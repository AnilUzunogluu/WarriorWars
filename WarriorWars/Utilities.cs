using System;

namespace WarriorWars
{
    static class Utilities
    {
        public static void ColoredWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void AttackResult(string w1Name, string w2Name, float damage, float w2Health)
        {
            Console.WriteLine($"{w1Name} attacked {w2Name}. \n{damage} damage inflicted." +
                              $"\n{w2Name} has {w2Health} health left.");
            Console.WriteLine("- - - - - - - - - - - - - - - -");
        }
    }
}