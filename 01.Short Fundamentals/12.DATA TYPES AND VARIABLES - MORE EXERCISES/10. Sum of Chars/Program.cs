using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < number; i++)
        {
            char cuurent = char.Parse(Console.ReadLine());
            sum += cuurent;
        }
        Console.WriteLine("The sum equals: {0}", sum);
    }
}