using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        List<int> revolver = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<string> players = Console.ReadLine().Split(' ').ToList();

        string left = "Left";
        string right = "Right";
        int bullet = 0; 
        int position = 2;
        int playerNumber = -1;
        foreach (int bulletHole in revolver)
        {
            if (bulletHole > 0)
            {
                bullet = bulletHole;
            }
        }
        for (int i = 0; i < players.Count; i++)
        {
            string[] player = players[i].Split(',').ToArray();
            int spins = int.Parse(player[0]);
            string direction = player[1];
            if (direction == left)
            {
                while (spins > 0)
                {
                    position++;
                    spins--;
                    if (position > revolver.Count - 1)
                    {
                        position = 0;
                    }
                }
            }
            else if (direction == right)
            {
                while (spins > 0)
                {
                    position--;
                    spins--;
                    if (position < 0)
                    {
                        position = revolver.Count - 1;
                    }
                }
            }
            if (revolver[position] == bullet)
            {
                playerNumber = i;
                break;
            }
            position--;
            if (position < 0)
            {
                position = revolver.Count - 1;
            }
        }
        if (playerNumber < 0)
        {
            Console.WriteLine("Everybody got lucky!");
        }
        else
        {
            Console.WriteLine("Game over! Player {0} is dead.", playerNumber);
        }
    }
}