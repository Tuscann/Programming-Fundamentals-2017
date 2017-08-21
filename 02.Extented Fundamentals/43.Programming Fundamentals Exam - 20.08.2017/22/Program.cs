using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<long> list = new List<long>();

        while (true)
        {
            string current = Console.ReadLine();
            if (current == "All ofboard!")
            {
                break;
            }
            list.Add(long.Parse(current));
        }               
        long sum = 0;
        long locomotive = list[0];
        List<long> printList = new List<long>();

        for (int i = 1; i < list.Count; i++)
        {                    
            sum += list[i];

            if (sum > locomotive)
            {
                long average = sum / i;

                
                for (int j = 1; j < list.Count; j++)
                {
                    printList.Add(list[j]);
                }
                long minDistance = printList.Min(n => Math.Abs(average - n));
                long closest = printList.First(n => Math.Abs(average - n) == minDistance);

                printList.Remove(closest);
                //Console.WriteLine(average);
               
                break;
            }
        }
        for (int k = printList.Count - 1; k >= 0; k--)
        {
            Console.Write("{0} ", printList[k]);
        }
        Console.WriteLine(locomotive);

    }
}