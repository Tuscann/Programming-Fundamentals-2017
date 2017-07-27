using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        char[] input = Console.ReadLine().ToCharArray();

        int sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '@')
            {
                break;
            }
            sum += (int)input[i];
        }
        char[] reverseArea = input.Reverse().ToArray();

        for (int i = 0; i < reverseArea.Length; i++)
        {
            if (reverseArea[i] == '@')
            {
                break;
            }
            sum -= (int)reverseArea[i];
        }
        if (sum >= 0)
        {
            Console.WriteLine("Call her!");
        }
        else
        {
            Console.WriteLine("She is not the one.");
        }
    }
}