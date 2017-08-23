using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    private static void Main() // 100/100
    {
        List<string> vehicles = Console.ReadLine().ToLower().Split(' ').ToList();
        string input = Console.ReadLine().ToLower();

        decimal vehiclesSold = 0;
        while (input != "end of customers!")
        {
            string[] data = input.Split(' ');

            string query = data[0].ToLower()[0] + data[2];

            int wantedIndex = -1;
            for (int i = 0; i < vehicles.Count; i++)
            {
                if (query == vehicles[i])
                {
                    wantedIndex = i;
                    break;
                }
            }

            if (wantedIndex == -1) { Console.WriteLine("No"); }
            else
            {
                string vehicle = vehicles[wantedIndex];
                int price = vehicle[0] * int.Parse(vehicle.Substring(1, vehicle.Length - 1));
                Console.WriteLine("Yes, sold for {0}$", price);
                vehiclesSold++;
                vehicles.RemoveAt(wantedIndex);
            }
            input = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Vehicles left: {0}", string.Join(", ", vehicles));
        Console.WriteLine("Vehicles sold: {0}", vehiclesSold);
    }
}