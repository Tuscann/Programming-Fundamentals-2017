using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int counter = 0;
        bool found = false;
        int printOne = 0;
        int printTwo = 0;

        for (int i = n; i <= m; i++)
        {
            for (int j = n; j <= m; j++)
            {
                //Console.WriteLine("{0} {1}", i, j);
                counter++;

                if (i + j == magicNumber)
                {
                    found = true;
                    printOne = i;
                    printTwo = j;
                }
            }
        }
        if (found == true)
        {
            Console.WriteLine("Number found! {0} + {1} = {2}", printOne, printTwo, printOne + printTwo);
        }
        else
        {
            Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
        }
    }
}