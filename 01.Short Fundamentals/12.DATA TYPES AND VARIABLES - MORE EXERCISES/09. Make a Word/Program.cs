using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        string sum = "";
        for (int i = 0; i < number; i++)
        {
            char charr = char.Parse(Console.ReadLine());
            sum += charr;
        }
        Console.Write("The word is: {0}",sum);
    }
}