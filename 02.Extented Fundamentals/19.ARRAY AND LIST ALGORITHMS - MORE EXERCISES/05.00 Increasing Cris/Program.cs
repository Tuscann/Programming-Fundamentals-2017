using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> listt = new List<int>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            List<int> curentrow = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (i == 0)
            {
                listt = curentrow;
            }
            else
            {
                int first = curentrow[0];

                foreach (int variable in listt)
                {
                    if (variable > first)
                    {
                        listt.InsertRange(listt.IndexOf(variable), curentrow);
                        break;
                    }
                    if (variable == first)
                    {
                        listt.InsertRange(listt.IndexOf(variable) + 1, curentrow);
                        break;
                    }


                }
                for (int number = 0; number < listt.Count - 1; number++)
                {
                    // 1 2 2 1  broken 
                    if ( listt[number] > listt[number + 1])
                    {
                        listt.RemoveRange(listt[number], listt.Count - listt[number]);
                        break;
                    }
                }
            }
            //Console.WriteLine();
            //Console.WriteLine("{0}", string.Join(" ", listt));
            //Console.WriteLine();
        }
        Console.WriteLine("{0}", string.Join(" ", listt));
    }
}