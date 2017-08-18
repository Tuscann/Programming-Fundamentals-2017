using System;
using System.Linq;
class ladyBugs
{
    static long[] field;
    static void Main()
    {
        field = new long[long.Parse(Console.ReadLine())];
        long[] ladybugpossition = Console.ReadLine().Split().Select(long.Parse).ToArray();
        field = BugsInField(field, ladybugpossition);

        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] inputTokkens = input.Split().ToArray();

            long ladybug = long.Parse(inputTokkens[0]);
            string direction = inputTokkens[1];
            long flyLength = long.Parse(inputTokkens[2]);

            switch (direction)
            {
                case "right":
                    {
                        MoveRight(ladybug, flyLength);
                        break;
                    }
                case "left":
                    {
                        MoveLeft(ladybug, flyLength);
                        break;
                    }
            }
            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", field));
    }

    private static void MoveLeft(long ladybug, long flyLength)
    {
        if (ladybug >= 0 && ladybug < field.Length)
        {
            if (field[ladybug] == 1)
            {
                long startIndex = ladybug;
                field[ladybug] = 0;
                if (flyLength > 0)
                {
                    for (long i = startIndex - flyLength; i >= 0; i--)
                    {
                        if (field[i] == 0)
                        {
                            field[i] = 1;
                            return;
                        }
                    }
                }
                else
                {
                    for (long i = startIndex - flyLength; i < field.Length; i++)
                    {
                        if (field[i] == 0)
                        {
                            field[i] = 1;
                            return;
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }
    }

    private static void MoveRight(long ladybug, long flyLength)
    {
        if (ladybug >= 0 && ladybug < field.Length)
        {
            if (field[ladybug] == 1)
            {
                long startIndex = ladybug;
                field[ladybug] = 0;
                if (flyLength > 0)
                {
                    for (long i = startIndex + flyLength; i < field.Length; i++)
                    {
                        if (field[i] == 0)
                        {
                            field[i] = 1;
                            return;
                        }
                    }
                }
                else
                {
                    for (long i = startIndex + flyLength; i >= 0; i--)
                    {
                        if (field[i] == 0)
                        {
                            field[i] = 1;
                            return;
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }
    }

    private static long[] BugsInField(long[] field, long[] ladybugpossition)
    {
        for (int i = 0; i < field.Length; i++)
        {
            for (int j = 0; j < ladybugpossition.Length; j++)
            {
                if (i == ladybugpossition[j] && ladybugpossition[j] < field.Length && ladybugpossition[j] >= 0)
                {
                    field[i] = 1;
                    break;
                }
            }
        }
        return field;
    }
}
