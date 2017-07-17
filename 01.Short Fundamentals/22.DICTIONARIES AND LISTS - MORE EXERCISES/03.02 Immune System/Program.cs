using System;
using System.Collections.Generic;
class Program
    {
        static void Main()
        {
            int startHealth = int.Parse(Console.ReadLine());
            int health = startHealth;
            List<string> virusesList = new List<string>();
        
            while (health > 0)
            {
                string input = Console.ReadLine();
                int virusStrenght = 0;
                int time = 0;

                if (input == "end") break;


                if (!virusesList.Contains(input))
                {
                    virusesList.Add(input);
                    for (int i = 0; i < input.Length; i++)
                    {
                        virusStrenght += input[i];
                    }
                    virusStrenght = virusStrenght / 3;
                    time = virusStrenght * input.Length;
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        virusStrenght += input[i];
                    }
                    virusStrenght = virusStrenght / 3;
                    time = virusStrenght * input.Length / 3;
                }

                health -= time;
                int minutes = time / 60;
                int seconds = time - minutes * 60;

                Console.WriteLine($"Virus {input}: {virusStrenght} => {time} seconds");
                if (health <= 0) break;
                Console.WriteLine($"{input} defeated in {minutes}m {seconds}s.");
                Console.WriteLine($"Remaining health: {health}");

                health += health * 20 / 100;
                if (health > startHealth)
                {
                    health = startHealth;
                }
            }
            if (health > 0) Console.WriteLine($"Final Health: {health}");
            else Console.WriteLine($"Immune System Defeated.");

        }
    }