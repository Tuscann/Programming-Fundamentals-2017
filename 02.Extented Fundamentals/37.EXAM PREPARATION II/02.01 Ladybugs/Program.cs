using System;
using System.Collections.Generic;
using System.Linq;

public class Ladybugs
{
    public static void Main() // 100/100
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] field = new int[fieldSize];
        List<int> bugsIndex = Console.ReadLine().Split(' ').Select(int.Parse).Where(a => a >= 0 && a < fieldSize).ToList();

        field = FillField(bugsIndex, fieldSize);
        string command = Console.ReadLine();
        while (command != "end")
        {
            string[] tokens = command.Split();
            int ladybugIndex = int.Parse(tokens[0]);
            string direction = tokens[1];
            int flyLength = int.Parse(tokens[2]);

            if (ladybugIndex < 0 || ladybugIndex >= field.Length) // invalid ladybug index
            {
                command = Console.ReadLine();
                continue;
            }
            if (field[ladybugIndex] == 0) // valid ladybug index but no ladybug on index
            {
                command = Console.ReadLine();
                continue;
            }
            MoveLadybug(field, ladybugIndex, flyLength, direction);
            command = Console.ReadLine();

        }
        Console.WriteLine(string.Join(" ", field));
    }

    private static void MoveLadybug(int[] field, int ladybugIndex, int flyLength, string direction)
    {
        field[ladybugIndex] = 0;
        bool leftArrayOrFoundPlace = false;
        while (!leftArrayOrFoundPlace)
        {
            switch (direction)
            {
                case "left":
                    {
                        ladybugIndex -= flyLength;
                        break;
                    }
                case "right":
                    {
                        ladybugIndex += flyLength;
                        break;
                    }
            }
            if (ladybugIndex < 0 || ladybugIndex >= field.Length) // left array
            {
                leftArrayOrFoundPlace = true;
                continue;
            }
            if (field[ladybugIndex] == 1) // stepped over another ladybug, keep flying
            {
                continue;
            }
            if (field[ladybugIndex] == 0) // found place in field
            {
                field[ladybugIndex] = 1;
                leftArrayOrFoundPlace = true;
            }
        }
    }

    private static int[] FillField( List<int> bugsIndex, int fieldSize)
    {
        int[] fillField = new int[fieldSize];
        foreach (int current in bugsIndex)
        {
            fillField[current] = 1;
        }
        return fillField;
    }
}
