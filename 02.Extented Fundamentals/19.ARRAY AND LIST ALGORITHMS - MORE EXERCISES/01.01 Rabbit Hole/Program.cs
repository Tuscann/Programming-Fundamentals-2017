using System;
using System.Collections.Generic;
using System.Linq;
public class RabbitHole
{
    public static void Main()
    {
        List<string> commands = Console.ReadLine().Split().ToList();

        int energy = int.Parse(Console.ReadLine());

        int currentIndex = 0;
        bool lastBomb = false;

        while (energy > 0)
        {
            string[] commandParams = commands[currentIndex].Split('|');
            string currentCommand = commandParams[0];
            lastBomb = false;

            if (currentCommand == "RabbitHole")
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
                break;
            }

            int value = int.Parse(commandParams[1]);

            switch (currentCommand)
            {
                case "Left":
                    currentIndex = Math.Abs(currentIndex - value) % commands.Count;
                    break;
                case "Right":
                    currentIndex = (currentIndex + value) % commands.Count;
                    break;
                case "Bomb":
                    commands.RemoveAt(currentIndex);
                    currentIndex = 0;
                    lastBomb = true;
                    break;
            }
            energy -= value;

            if (commands[commands.Count - 1] != "RabbitHole")
            {
                commands.RemoveAt(commands.Count - 1);
            }

            commands.Add("Bomb|" + energy);
        }
        if (energy <= 0 && lastBomb)
        {
            Console.WriteLine("You are dead due to bomb explosion!");
        }
        else if (energy <= 0 && !lastBomb)
        {
            Console.WriteLine("You are tired. You can't continue the mission.");
        }
    }
}