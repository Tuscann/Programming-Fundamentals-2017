using System;
class Program
{
    static void Main()
    {
        int counter = int.Parse(Console.ReadLine());
        int x = 1;
        int sum = 0;

        for (int i = 1; i <= counter; i++)
        {
            Console.WriteLine("{0}", x);
            sum += x;
            x += 2;
        }
        Console.WriteLine("Sum: {0}", sum);
    }
}

