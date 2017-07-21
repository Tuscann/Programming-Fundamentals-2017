using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().ToArray();

        Random rnd = new Random();

        for (int i = 0; i < input.Length; i++)
        {
            int pos2 = rnd.Next(input.Length);

            string temp = input[i];
            input[i] = input[pos2];
            input[pos2] = temp;
        }
        foreach (var word in input)
        {
            Console.WriteLine("{0}", word);
        }
    }
}