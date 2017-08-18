using System;
class P09_MultiplicationTable
{
    static void Main() // 100/100
    {
        byte number = byte.Parse(Console.ReadLine());
        for (byte i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} X {i} = {number * i}");
        }
    }
}
