using System;
using System.Linq;
public class Wormhole
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int steps = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                steps++;
            }
            else
            {
                int index = numbers[i];
                numbers[i] = 0;
                i = index - 1;
            }
        }
        Console.WriteLine(steps);
    }
}