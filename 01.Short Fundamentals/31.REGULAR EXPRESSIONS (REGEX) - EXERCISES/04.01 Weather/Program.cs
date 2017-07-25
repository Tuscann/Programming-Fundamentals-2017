using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main() // 100/100
    {
        string inputLine = Console.ReadLine();

        Regex weatherSplitter = new Regex(@"([A-Z]{2})(\d{1,2}\.\d{1,2})([A-Za-z]+)\|");

        Dictionary<string, CityTempWeather> solution = new Dictionary<string, CityTempWeather>();

        while (inputLine != "end")
        {
            var weatherMatcher = weatherSplitter.Matches(inputLine);

            foreach (Match group in weatherMatcher)
            {
                string cityName = group.Groups[1].Value.ToString();
                
                CityTempWeather currentCity = new CityTempWeather()
                {
                    city = group.Groups[1].Value,
                    temperature = decimal.Parse(group.Groups[2].Value),
                    weather = group.Groups[3].Value
                };

                if (!solution.ContainsKey(cityName))
                {
                    solution.Add(cityName, currentCity);
                }
                else
                {
                    solution[cityName] = currentCity;
                }
            }
            inputLine = Console.ReadLine();
        }

        foreach (var city in solution.OrderBy(x => x.Value.temperature))
        {
            Console.WriteLine($"{city.Key} => {city.Value.temperature:f2} => {city.Value.weather}");
        }
    }
}

class CityTempWeather
{
    public string city { get; set; }
    public decimal temperature { get; set; }
    public string weather { get; set; }
}
