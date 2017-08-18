using System;

class P10_MultiplicationTable2_0
{
    static void Main() // 100/100
    {
        byte number = byte.Parse(Console.ReadLine());
        byte multiplier = byte.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
            multiplier++;
        } while (multiplier <= 10);
    }
}