using System;
class Program
{
    static void Main()
    {
        long firstNumber = long.Parse(Console.ReadLine());
        long SecoundNnumber = long.Parse(Console.ReadLine());
        
        var lower = Math.Min(firstNumber, SecoundNnumber);
        var higher = Math.Max(firstNumber, SecoundNnumber);
        long sum = lower * 4 + higher * 10;

        Console.WriteLine(sum);
    }
}