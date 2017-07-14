using System;
using System.Collections.Generic;
using System.Linq;
public class CamelsBack
{
    public static void Main()
    {
        List<int> buildingsInTheCity = Console.ReadLine()
            .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        int camelBackSize = int.Parse(Console.ReadLine());

        string result = StableBuildingsOnTheBackOfCamel(buildingsInTheCity, camelBackSize);

        Console.WriteLine(result);
    }

    static string StableBuildingsOnTheBackOfCamel(List<int> buildingsInTheCity, int camelBackSize)
    {
        int lenghtOfTheBuildings = buildingsInTheCity.Count;
        string result = string.Empty;

        if (lenghtOfTheBuildings <= camelBackSize)
        {
            result = $"already stable: {string.Join(" ", buildingsInTheCity)}";
        }
        else if (lenghtOfTheBuildings > camelBackSize)
        {
            string removeBuildings = string.Empty;
            int rounds = 0;
            int buildingsToRemove = 0;

            buildingsToRemove = lenghtOfTheBuildings - camelBackSize;

            rounds = buildingsToRemove / 2;

            removeBuildings = RemoveByildings(buildingsInTheCity, buildingsToRemove);

            result = $"{rounds} rounds \nremaining: {removeBuildings}";
        }

        return result;
    }

    static string RemoveByildings(List<int> buildingsInTheCity, int buildingsToRemove)
    {
        List<int> resultList = new List<int>();

        int removeAtStart = buildingsToRemove / 2;

        int removeAtEnd = buildingsInTheCity.Count - removeAtStart;

        for (int i = removeAtStart; i < removeAtEnd; i++)
        {
            resultList.Add(buildingsInTheCity[i]);
        }
        return string.Join(" ", resultList);
    }
}
