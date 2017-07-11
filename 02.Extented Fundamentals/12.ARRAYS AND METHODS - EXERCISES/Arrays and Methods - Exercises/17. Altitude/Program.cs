using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        long altutude = int.Parse(input[0]);

        for (int i = 1; i < input.Length - 1; i += 2)
        {
            string command = input[i];
            int number = int.Parse(input[i + 1]);

            if (command == "up")
            {
                altutude += number;
            }
            else if (command == "down")
            {
                altutude -= number;
            }
            if (altutude <= 0)
            {
                Console.WriteLine("crashed");
                break;
            }
        }
        if (altutude>0)
        {
            Console.WriteLine("got through safely. current altitude: {0}m", altutude);
        }
    }
}