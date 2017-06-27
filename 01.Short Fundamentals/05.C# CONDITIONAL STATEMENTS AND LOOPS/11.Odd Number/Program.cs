using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            int x = Math.Abs(int.Parse(Console.ReadLine()));

            if (x % 2 == 1)
            {
                Console.WriteLine("The number is: {0}", x);
                break;
            }
            else
            {
                Console.WriteLine("Please write an odd number.");
            }
        }

    }
}