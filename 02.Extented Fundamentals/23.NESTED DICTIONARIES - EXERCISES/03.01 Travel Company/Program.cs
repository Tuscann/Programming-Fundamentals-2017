using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main() // 100/100
    {
        Dictionary<string, Dictionary<string, int>> citiesData = new Dictionary<string, Dictionary<string, int>>();
        string transportData = Console.ReadLine();
        while (transportData != "ready")
        {
            string[] currentCityData = transportData.Split(new[] { ':', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

            string city = currentCityData[0];
            string[] vehicleAndCapacity = currentCityData;

            if (!citiesData.ContainsKey(city))
            {
                citiesData[city] = new Dictionary<string, int>();
            }

            for (int index = 1; index < vehicleAndCapacity.Length; index += 2)
            {
                string transportType = vehicleAndCapacity[index];
                int seats = int.Parse(vehicleAndCapacity[index + 1]);

                if (!citiesData[city].ContainsKey(transportType))
                {
                    citiesData[city][transportType] = 0;
                }
                citiesData[city][transportType] = seats;
            }

            transportData = Console.ReadLine();
        }
        transportData = Console.ReadLine();

        while (transportData != "travel time!")
        {
            string[] currentCityAndTourists = transportData.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string city = currentCityAndTourists[0];
            int tourists = Convert.ToInt32(currentCityAndTourists[1]);

            int transportCapacities = citiesData[city].Sum(places => places.Value);

            if (tourists <= transportCapacities)
            {
                Console.WriteLine($"{city} -> all {tourists} accommodated");
            }
            else
            {
                Console.WriteLine($"{city} -> all except {tourists - transportCapacities} accommodated");
            }

            transportData = Console.ReadLine();
        }
    }
}