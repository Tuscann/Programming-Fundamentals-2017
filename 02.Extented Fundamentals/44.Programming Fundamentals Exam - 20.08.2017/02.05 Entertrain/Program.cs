using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()  //  100/100
    {
        int locoPower = int.Parse(Console.ReadLine());
        
        List<int> wagonTrain = new List<int>();

        while (true)
        {
            string theFollowUp = Console.ReadLine();
            if (theFollowUp == "All ofboard!")
            {
                break;
            }
            wagonTrain.Add(int.Parse(theFollowUp));

            if (wagonTrain.Sum() > locoPower)
            {
                var nearest = wagonTrain.OrderBy(x => Math.Abs(x - wagonTrain.Average())).First();
                wagonTrain.Remove(nearest);
            }
        }
        wagonTrain.Reverse();

        Console.WriteLine(string.Join(" ", wagonTrain) + " " + locoPower);
    }
}