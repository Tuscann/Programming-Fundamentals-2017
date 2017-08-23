using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] arrays = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool same = true;

        for (int i = 0; i < arrays.Length - 1; i++)
        {
            if (arrays[i] == arrays[i + 1])
            {
                same = false;
            }
        }
        Console.WriteLine(same ? "No" : "Yes");
    }
}