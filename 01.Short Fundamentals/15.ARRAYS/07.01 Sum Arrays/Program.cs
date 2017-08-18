using System;
using System.Linq;
class P07_SumArrays
{
    static void Main() // 100/100
    {
        int[] array1 = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToArray();

        int[] array2 = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToArray();

        int[] sumOfArrays = new int[Math.Max(array1.Length, array2.Length)];
        for (int i = 0; i < sumOfArrays.Length; i++)
        {
            sumOfArrays[i] = array1[i % array1.Length] + array2[i % array2.Length];
        }
        Console.WriteLine(string.Join(" ", sumOfArrays));
    }
}