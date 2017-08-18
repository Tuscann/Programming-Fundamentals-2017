using System;
class P12_TestNumbers
{
    static void Main() // 100/100
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int boundary = int.Parse(Console.ReadLine());

        int combinations = 0;
        int sum = 0;
        for (int i = number1; i >= 1; i--)
        {
            for (int j = 1; j <= number2; j++)
            {
                sum += 3 * i * j;
                combinations++;
                if (sum >= boundary)
                {
                    Console.WriteLine($"{combinations} combinations");
                    Console.WriteLine($"Sum: {sum} >= {boundary}");
                    return;
                }
            }
        }
        Console.WriteLine($"{combinations} combinations");
        Console.WriteLine($"Sum: {sum}");
    }
}
