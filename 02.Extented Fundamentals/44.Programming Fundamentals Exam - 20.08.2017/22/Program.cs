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
        list.RemoveAt(0);

        for (int i = 0; i < list.Count; i++)
        {                    
            sum += list[i];

            if (sum > locomotive)
            {
                long average = sum / (i+1);
                //Console.WriteLine(average);

                long minDistance = list.Min(n => Math.Abs(average - n));
                long closest = list.First(n => Math.Abs(average - n) == minDistance);
                sum -= closest;
                list.Remove(closest);
            }
        }
        list.Reverse();
        Console.WriteLine("{0} {1}",string.Join(" ",list),locomotive);
    }
}