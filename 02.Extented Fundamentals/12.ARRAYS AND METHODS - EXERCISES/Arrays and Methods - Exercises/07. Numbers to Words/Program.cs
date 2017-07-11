using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 100)
            {
                if (number == 100)
                {
                    Console.WriteLine("one-hundred");
                }
                else if (number == 200)
                {
                    Console.WriteLine("two-hundred");
                }
                else if (number == 300)
                {
                    Console.WriteLine("three-hundred");
                }
                else if (number == 400)
                {
                    Console.WriteLine("four-hundred");
                }
                else if (number == 500)
                {
                    Console.WriteLine("five-hundred");
                }
                else if (number == 600)
                {
                    Console.WriteLine("six-hundred");
                }
                else if (number == 700)
                {
                    Console.WriteLine("seven-hundred");
                }
                else if (number == 800)
                {
                    Console.WriteLine("eight-hundred");
                }
                else if (number == 900)
                {
                    Console.WriteLine("nine-hundred");
                }
                else if (number > 999)
                {
                    Console.WriteLine("too large");
                }
                else if (number < -999)
                {
                    Console.WriteLine("too small");
                }
            }
        }
    }
}