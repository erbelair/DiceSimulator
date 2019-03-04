using DiceSimulator.Dice.Rebellion;
using System;
using System.Collections.Generic;

namespace DiceSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================");
            Console.WriteLine("---- Dice Simulator ----");
            Console.WriteLine("========================");
            Console.WriteLine();

            string input;
            do
            {
                Console.Write("Does attacker have advantage (lightsaber)? ");
                input = Console.ReadLine();
            }
            while (!input.Equals("Y", StringComparison.OrdinalIgnoreCase) && !input.Equals("N", StringComparison.OrdinalIgnoreCase));

            var hasAdvantage = input.Equals("Y", StringComparison.OrdinalIgnoreCase);

            var die = new Die(new Random());
            Dictionary<string, int> results = new Dictionary<string, int>();

            for (int i = 0; i < 1000000; i++)
            {
                var result = die.Roll();
                
                if (results.ContainsKey(result.Name))
                {
                    results[result.Name]++;
                }
                else
                {
                    results.Add(result.Name, 1);
                }
            }

            Console.WriteLine("RESULTS:");
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key}: {result.Value} ({((double)result.Value / 1000000).ToString("P")}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
