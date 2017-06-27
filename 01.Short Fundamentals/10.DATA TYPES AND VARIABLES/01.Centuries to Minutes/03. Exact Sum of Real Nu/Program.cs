using System;
class Program
{
    static void Main()
    {
        ulong numbers = ulong.Parse(Console.ReadLine());

        decimal sum = 0;
        for (ulong i = 0; i < numbers; i++)
        {
            sum = sum + decimal.Parse(Console.ReadLine());
        }
        Console.WriteLine("{0}", sum);
    }
}