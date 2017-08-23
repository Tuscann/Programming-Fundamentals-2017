using System;
class Program
{
    static void Main() // 100/100
    {
        int first = int.Parse(Console.ReadLine());
        int secound = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int min = MinValue(MinValue(first, secound), MinValue(secound, third));
        Console.WriteLine(min);
    }
    static int MinValue(int a, int b)
    {
        if (a < b) return a;
        return b;
    }
}