using System;
class Program
{
    static void Main()
    {
        for (int i = 3; i <= 100; i += 3)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}