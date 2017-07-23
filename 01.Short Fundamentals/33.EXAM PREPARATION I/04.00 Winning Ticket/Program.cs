using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {

        string[] tickests = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string ticket in tickests)
        {
            if (ticket.Length == 20)
            {
                char[] x = ticket.ToCharArray();

                var list = new Dictionary<char, List<int>>();

                for (int i = 0; i < x.Length / 2; i++)
                {
                    if (x[i] == x[i + 1])
                    {
                        Console.WriteLine(x[i]);
                    }
                }



            }
            else
            {
                Console.WriteLine("invalid ticket");
            }


        }

    }
}