using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main() //To DO
    {
        var first = Console.ReadLine().Reverse().ToArray();
        var secound = Console.ReadLine().Reverse().ToArray();
        int[] sum = new int[Math.Max(first.Length, secound.Length)];


        Console.WriteLine(first);

        if (first.Length == secound.Length)
        {
            for (int i = 0; i < first.Length; i++)
            {
                int curent = first[i] + secound[i];
                int afterToAdd = 0;

                if (curent > 10)
                {
                    afterToAdd = curent % 10;
                    int addNow = curent / 10;
                    sum[i] = first[i] + secound[i] + addNow;
                }
                if (curent == 10)
                {
                    afterToAdd = 1;
                    sum[i] = first[i] + secound[i];
                }

            }
        }


    }
}