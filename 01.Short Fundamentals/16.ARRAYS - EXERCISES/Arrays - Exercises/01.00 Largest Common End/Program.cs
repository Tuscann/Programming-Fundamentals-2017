using System;
class Program
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split();
        string[] secound = Console.ReadLine().Split();
        int leftcounter = 0;
        int rightcounter = 0;

        int smallLenght = Math.Min(first.Length, secound.Length);

        for (int i = 0; i < smallLenght; i++)
        {
            if (first[i] == secound[i])
            {
                leftcounter++;
            }
            if (first[first.Length - 1 - i] == secound[secound.Length - 1 - i])
            {
                rightcounter++;
            }
        }
        Console.WriteLine(Math.Max(leftcounter, rightcounter));
    }
}