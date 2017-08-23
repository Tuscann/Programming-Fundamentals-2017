using System;

public class elevator
{
    public static void Main() // 100/100
    {
        int people = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        int result = (int)Math.Ceiling((double)people / capacity);

        Console.WriteLine(result);
    }
}