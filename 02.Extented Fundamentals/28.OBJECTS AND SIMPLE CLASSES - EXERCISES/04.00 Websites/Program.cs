using System;
using System.Collections.Generic;

class Websites
{
    static void Main() // 100/100
    {
        List<Website> newWebsites = new List<Website>();
        newWebsites = GetWebsites(newWebsites);
        PrintWebsites(newWebsites);
    }

    static List<Website> GetWebsites(List<Website> newWebsites)
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] splitInput = input.Split(new string[] { " | ", "," },
                StringSplitOptions.RemoveEmptyEntries);

            string host = splitInput[0];
            string domain = splitInput[1];
            List<string> queries = new List<string>();
            queries = GetQueries(splitInput);

            Website website = new Website()
            {
                Host = host,
                Domain = domain,
                Queries = queries,
            };

            newWebsites.Add(website);
            input = Console.ReadLine();
        }
        return newWebsites;
    }
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }
    }

    static List<string> GetQueries(string[] splitInput)
    {
        List<string> queries = new List<string>();

        for (int index = 2; index < splitInput.Length; index++)
        {
            queries.Add(splitInput[index]);
        }
        return queries;
    }

    static void PrintWebsites(List<Website> newWebsites)
    {
        foreach (Website website in newWebsites)
        {
            string host = website.Host;
            string domain = website.Domain;
            List<string> queriesList = website.Queries;

            if (queriesList.Count == 0)
            {
                Console.WriteLine("https://www.{0}.{1}", host, domain);
            }
            else
            {
                Console.Write("https://www.{0}.{1}/query?=", host, domain);

                string queries = String.Empty;
                for (int index = 0; index < queriesList.Count - 1; index++)
                {
                    queries += $"[{queriesList[index]}]&";
                }
                queries += $"[{queriesList[queriesList.Count - 1]}]";
                Console.WriteLine(queries);
            }
        }
    }
}