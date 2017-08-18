using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] indexesOfLadybug = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] field = new int[fieldSize];

        foreach (int index in indexesOfLadybug)
        {
            if (index < 0 || index >= fieldSize)
            {
                continue;
            }

            field[index] = 1;
        }
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            string[] tokens = input.Split(' ').ToArray();
            int index = int.Parse(tokens[0]);
            string direction = tokens[1];
            int flyLength = int.Parse(tokens[2]);

            if (index < 0 || index >= fieldSize)
            {
                continue;
            }

            if (field[index] == 0)
            {
                continue;
            }

            int position = index;
            field[index] = 0;

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

                if (position < 0 || position >= fieldSize)
                {
                    break;
                }

                if (field[position] != 1)
                {
                    field[position] = 1;
                    break;
                }
            }
        }
        Console.WriteLine(string.Join(" ", field));
    }
}
