using System;
class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int secound = int.Parse(Console.ReadLine());
        Console.Write("Before:\na = {0}\nb = {1}\n", first, secound);

        int temp = first;
        first = secound;
        secound = temp;
        Console.WriteLine("After:\na = {0}\nb = {1}\n", first, secound);
    }
}