using System;
class Program  // 100/100
{
    static int GetMax(int a, int b)
    {
        int max = int.MinValue;
        if (a >= b)
        {
            max = a;
        }
        else if (a <= b)
        {
            max = b;
        }
        return max;
    }
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int secound = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int max = GetMax(first, GetMax(secound, third));
        Console.WriteLine(max);
    }
}