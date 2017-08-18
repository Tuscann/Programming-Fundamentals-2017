using System;
using System.Linq;

class Program
{
    static void Main() // 100/100
    {
        int size = int.Parse(Console.ReadLine());
        int[] ladybugIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int[] field = new int[size];

        foreach (int ladybugIndex in ladybugIndexes)
        {
            if (ladybugIndex < 0 || ladybugIndex >= size)
            {
                continue;
            }

            field[ladybugIndex] = 1;
        }
        
        while (true) //loop for each command
        {
            string command = Console.ReadLine();
            if (command == "end")
            {
                break;
            }

            string[] commandParts = command
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int currentLadyBugIndex = int.Parse(commandParts[0]);
            string direction = commandParts[1];
            int flyLength = int.Parse(commandParts[2]);

            if (currentLadyBugIndex < 0 || currentLadyBugIndex >= size)
            {
                continue;
            }

            if (field[currentLadyBugIndex] == 0)
            {
                continue;
            }

            field[currentLadyBugIndex] = 0;
            int position = currentLadyBugIndex;

            //loop for each movement of the current ladybug
            while (true)
            {
                if (direction == "right")
                {
                    position += flyLength;
                }
                else
                {
                    position -= flyLength;
                }

                if (position < 0 || position >= size)
                {
                    break;
                }

                //there is an another ladybug here
                if (field[position] == 0)
                {
                    field[position] = 1;
                    break;
                }
            }
        }

        Console.WriteLine(string.Join(" ", field));
    }
}