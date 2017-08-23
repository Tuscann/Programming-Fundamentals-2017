using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        char[] charArea = Console.ReadLine().ToCharArray();
        int[] integerArea = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
       
        for (int i = 0; i < integerArea.Length; i++)
        {
            if (integerArea[i] % 2 == 0)
            {
                charArea[i] -= (char)integerArea[i];
            }
            else
            {
                charArea[i] += (char) integerArea[i];
            }
        }
        Console.WriteLine(string.Join("", charArea));
    }
}