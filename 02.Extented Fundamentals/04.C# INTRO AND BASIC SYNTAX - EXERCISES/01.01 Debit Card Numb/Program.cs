using System;
public class P01_DebitCardNumber
{
    public static void Main() // 100/100
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int num4 = int.Parse(Console.ReadLine());

        Console.WriteLine("{0:D4} {1:D4} {2:0000} {3:0000}", num1, num2, num3, num4);
    }
}