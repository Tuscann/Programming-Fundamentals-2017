using System;
class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int secound = int.Parse(Console.ReadLine());
        
        if (first > secound)
        {
            int temp = first;
            first = secound;
            secound = temp;
        }
        for (int j = first; j <= secound; j++)
        {
            Console.WriteLine(j);
        }
    }
}