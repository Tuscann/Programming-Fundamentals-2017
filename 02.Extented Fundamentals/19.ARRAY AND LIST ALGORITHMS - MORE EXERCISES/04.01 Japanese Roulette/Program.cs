using System;
using System.Collections.Generic;
using System.Linq;
public class JapaneseRoulette
{
    public static void Main()
    {
        List<int> cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<string> players = Console.ReadLine().Split(' ').ToList();

        int beginPosition = cylinder.FindIndex(num => num == 1);
        int endPosition = 0;

        for (int i = 0; i < players.Count; i++)
        {
            string[] currentPlayer = players[i].Split(',');
            int strength = int.Parse(currentPlayer[0]);
            string direction = currentPlayer[1];

            switch (direction.ToLower())
            {
                case "right":
                    endPosition = beginPosition + strength % cylinder.Count;

                    if (endPosition >= cylinder.Count)
                    {
                        endPosition -= cylinder.Count;
                    }
                    break;

                case "left":
                    endPosition = beginPosition - strength % cylinder.Count;

                    if (endPosition < 0)
                    {
                        endPosition += cylinder.Count;
                    }
                    break;
            }
            beginPosition = endPosition;

            if (endPosition == 2)
            {
                Console.WriteLine($"Game over! Player {i} is dead.");
                return;
            }
            beginPosition++;
        }
        Console.WriteLine("Everybody got lucky!");
    }
}
