using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var list = new List<int>();
        
        while (true)
        {
            string current = Console.ReadLine();
            if (current == "All ofboard!")
            {
                break;
            }
            list.Add(int.Parse(current));

        }
        int locomotivePower = list[0];
        int totalWeight = 0;
        int average = -3213123;
        
        for (int i = 1; i < list.Count; i++)
        {
            totalWeight += list[i];
            if (locomotivePower < totalWeight)
            {
                average = (int)(totalWeight / i);
                break;
            }
            
        }
        if (average!= -3213123)
        {
            int differnce = 987659;
            int numberToRemove = 0;
           

            for (int i = 1; i < list.Count; i++)
            {
                int cuurenttDifeence = Math.Abs(average - list[i]);

                if (cuurenttDifeence < differnce)
                {
                    differnce = cuurenttDifeence;
                    numberToRemove = list[i];
                }
            }
            //Console.WriteLine(differnce);
            //Console.WriteLine(numberToRemove);

            list.Remove(list.Single(x => x == numberToRemove));
        }
        Console.WriteLine(average);

        for (int i = list.Count - 1; i >= 0; i--)
        {
            Console.Write("{0} ", list[i]);
        }
    }
}