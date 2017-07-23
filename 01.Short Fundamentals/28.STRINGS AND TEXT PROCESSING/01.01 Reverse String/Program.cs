using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        // string output1 = input.ToCharArray().Reverse().ToString();
        string output2 = new string(input.Reverse().ToArray());
        Console.WriteLine(output2);
    }
}