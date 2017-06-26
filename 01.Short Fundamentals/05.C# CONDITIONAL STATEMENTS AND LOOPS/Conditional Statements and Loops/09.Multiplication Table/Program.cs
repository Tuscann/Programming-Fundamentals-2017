using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} X {1} = {2}", number, i, number * i);
        }
    }
}

