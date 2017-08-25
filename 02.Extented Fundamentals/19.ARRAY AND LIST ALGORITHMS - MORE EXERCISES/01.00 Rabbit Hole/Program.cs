using System;
using System.Collections.Generic;
using System.Linq;
public class RabbitHole
{
    public static void Main() // 100/100
    {
        List<string> obstacles = Console.ReadLine().Split(' ').ToList();
        int energy = int.Parse(Console.ReadLine());

        bool bombExplosion = false;
        int position = 0;

        while (true)
        {
            string currentObstacle = obstacles[position];

            if (energy <= 0 && bombExplosion)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
                break;
            }

            if (energy <= 0)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
                break;
            }

            if (currentObstacle == "RabbitHole")
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
                break;
            }

            string[] currentObstacleElements = currentObstacle.Split('|');
            string direction = currentObstacleElements[0];
            int jumps = int.Parse(currentObstacleElements[1]);

            switch (direction)
            {
                case "Right":
                    position += jumps % obstacles.Count;
                    break;

                case "Left":
                    position -= jumps % obstacles.Count;
                    position = Math.Abs(position);

                    break;

                case "Bomb":
                    obstacles.RemoveAt(position);
                    position = 0;
                    bombExplosion = true;

                    break;
            }
            energy -= jumps;

            if (obstacles.Last() != "RabbitHole")
            {
                obstacles.RemoveAt(obstacles.Count - 1);
            }

            obstacles.Add(string.Format($"Bomb|{energy}"));
        }
    }
}