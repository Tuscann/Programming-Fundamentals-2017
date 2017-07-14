using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> firstLine = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondLine = Console.ReadLine().Split().Select(int.Parse).ToList();

        int minCount = 0;

        if (Math.Abs(firstLine.Min(element => Math.Abs(element))) < Math.Abs(secondLine.Min(element => Math.Abs(element))))
        {
            int lowestNumber = Math.Abs(firstLine.Min(element => Math.Abs(element)));

            while (lowestNumber > 0)
            {
                minCount++;
                lowestNumber /= 10;
            }
        }
        else if (Math.Abs(firstLine.Min(element => Math.Abs(element))) == 0 || Math.Abs(secondLine.Min(element => Math.Abs(element))) == 0)
        {
            minCount = 1;
        }
        else
        {
            int lowestNumber = Math.Abs(secondLine.Min(element => Math.Abs(element)));

            while (lowestNumber > 0)
            {
                minCount++;

                lowestNumber /= 10;
            }
        }
        for (int i = 0; i < firstLine.Count; i++)
        {
            int currentNumber = Math.Abs(firstLine[i]);
            int count = 0;

            while (currentNumber > 0)
            {
                count++;

                currentNumber /= 10;
            }

            if (count > minCount)
            {
                firstLine.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < secondLine.Count; i++)
        {
            int currentNumber = Math.Abs(secondLine[i]);
            int count = 0;

            while (currentNumber > 0)
            {
                count++;

                currentNumber /= 10;
            }

            if (count > minCount)
            {
                secondLine.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0, j = 0; i < secondLine.Count; i++, j += 2)
        {
            if (firstLine.Count == 0)
            {
                firstLine = secondLine;
                break;
            }
            try
            {
                firstLine.Insert(j, secondLine[i]);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                j--;
                firstLine.Insert(j, secondLine[i]);
            }

        }
        Console.WriteLine(string.Join(" ", firstLine));
    }
}
