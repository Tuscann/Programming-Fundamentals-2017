using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            int curremt = int.Parse(Console.ReadLine());
            if (curremt < 0)
            {
                counter++;
            }
            array[i] = curremt;
        }
        Console.WriteLine(counter);
    }
}