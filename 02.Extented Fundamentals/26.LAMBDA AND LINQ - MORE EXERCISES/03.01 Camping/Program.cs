using System;
using System.Collections.Generic;
using System.Linq;

public class NigthsCamping  // 100/100
{
    public string Name { get; set; }
    public List<string> Campers { get; set; }
    public List<int> Nights { get; set; }

    public Double AllNights => this.Nights.Sum();
}

public class Camping
{
    static string name;
    static string camper;
    static int nights;

    static NigthsCamping currentNameModelNights;
    static List<NigthsCamping> campersCollection = new List<NigthsCamping>();

    public static void Main()
    {
        ReadGivenDataFrom(Console.ReadLine());
        PrintCampersColectionByGivenOrder();
    }

    static void ReadGivenDataFrom(string campers)
    {
        if (campers != "end")
        {
            ParseDataFrom(campers);
            AddDataToCamperCollection();
            ReadGivenDataFrom(Console.ReadLine());
        }
        else return;
    }

    static void ParseDataFrom(string campers)
    {
        var splitedCampers = campers.Split(' ');
        name = splitedCampers.First();
        camper = splitedCampers.ElementAt(1);
        nights = Convert.ToInt32(splitedCampers.Last());
    }

    static void AddDataToCamperCollection()
    {
        if (campersCollection.Any(x => x.Name == name))
            AddNewInformation();
        else
            CreateNewObject();
    }

    static void AddNewInformation()
    {
        currentNameModelNights = campersCollection.Where(x => x.Name == name).First();
        if (!currentNameModelNights.Campers.Contains(camper))
        {
            currentNameModelNights.Campers.Add(camper);
        }
        currentNameModelNights.Nights.Add(nights);
    }

    static void CreateNewObject()
    {
        currentNameModelNights = new NigthsCamping();
        currentNameModelNights.Name = name;

        AddCamperToTheGivenName();
        AddNightsToStayToTheGivenName();

        campersCollection.Add(currentNameModelNights);
    }

    static void AddCamperToTheGivenName()
    {
        currentNameModelNights.Campers = new List<string>();
        currentNameModelNights.Campers.Add(camper);
    }

    static void AddNightsToStayToTheGivenName()
    {
        currentNameModelNights.Nights = new List<int>();
        currentNameModelNights.Nights.Add(nights);
    }

    static void PrintCampersColectionByGivenOrder()
    {
        campersCollection = SortCamperCollection();
        foreach (var name in campersCollection)
        {
            Console.WriteLine($"{name.Name}: {name.Campers.Count}");
            foreach (var camper in name.Campers)
            {
                Console.WriteLine($"***{camper}");
            }
            Console.WriteLine($"Total stay: {name.AllNights} nights");
        }
    }

    static List<NigthsCamping> SortCamperCollection()
    {
        return campersCollection.OrderByDescending(x => x.Campers.Count)
            .ThenBy(x => x.Name.Length).ToList();
    }
}