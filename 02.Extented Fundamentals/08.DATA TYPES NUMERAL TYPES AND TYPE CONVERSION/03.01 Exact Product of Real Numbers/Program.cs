using System;
class Program
{
    static void Main() // 100/100
    {
        int a = int.Parse(Console.ReadLine());
        decimal sum = decimal.Parse(Console.ReadLine());

        for (int i = 1; i < a; i++)
        {
            sum *= decimal.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}