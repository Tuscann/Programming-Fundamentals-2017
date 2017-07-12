using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int counter = 0;
        string word = String.Empty;

        string[] input = Console.ReadLine().Split(' ').ToArray();

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                counter++;
                if (counter == 2)
                {
                    word = input[i];
                }
            }
            else if (input[i] != input[i + 1])
            {
                counter = 0;
            }
        }
        Console.WriteLine("{0} {0} {0}", word);
    }
}