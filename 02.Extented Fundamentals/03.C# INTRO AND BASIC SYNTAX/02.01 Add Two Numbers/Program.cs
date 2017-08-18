using System;
public class P02_AddTwoNumbers
{
    public static void Main() // 100/100
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        int sum = number1 + number2;

        Console.WriteLine($"{number1} + {number2} = {sum}");
    }
}