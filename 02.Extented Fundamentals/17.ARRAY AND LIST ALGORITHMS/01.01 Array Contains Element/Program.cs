using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int neededDigit = int.Parse(Console.ReadLine());
        bool lamp = false;

        foreach (int arrayDigit in arrayOfNumbers)
        {
            if (arrayDigit == neededDigit)
            {
                lamp = true;
                Console.WriteLine("yes");
                break;
            }
        }

        if (!lamp)
        {
            Console.WriteLine("no");
        }
    }
}