using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int secound_number = int.Parse(Console.ReadLine());

        if (number > 10 || secound_number > 10)
        {
            Console.WriteLine("{0} X {1} = {2}", number, secound_number, number * secound_number);
        }
        else
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i >= secound_number)
                {
                    Console.WriteLine("{0} X {1} = {2}", number, secound_number, number * secound_number);
                    secound_number++;
                }
            }
        }
    }
}

