using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var comands = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        bool isOK = true;
        int start = comands[1];
        int end = comands[0];

        for (int i = start; i < end; i++)
        {
            if (input[i] == comands[2])
            {
                Console.WriteLine("YES!");
                isOK = false;
            }
        }
        if (isOK)
        {
            Console.WriteLine("NO!");
        }
    }
}