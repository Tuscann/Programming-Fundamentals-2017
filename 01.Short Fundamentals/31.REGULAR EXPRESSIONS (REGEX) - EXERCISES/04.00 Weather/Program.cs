using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
    {
        static void Main() // 100/100
        {
            Dictionary<string, Dictionary<double, string>> dic = new Dictionary<string, Dictionary<double, string>>();

            string pattern = @"([A-Z]{2})([0-9]*.[0-9]*)([A-z]{1,})\|";
            while (true)
            {
                string current = Console.ReadLine();
                if (current == "end")
                {
                    break;
                }
                MatchCollection matches = Regex.Matches(current, pattern);

                foreach (Match match in matches)
                {
                    string cityName = match.Groups[1].Value.ToString();
                    double cityTemperature = double.Parse(match.Groups[2].Value);
                    string cityWeather = match.Groups[3].Value;
                    
                    if (dic.ContainsKey(cityName))
                    {
                        dic.Remove(cityName);
                    }
                    if (!dic.ContainsKey(cityName))
                    {
                        dic[cityName] = new Dictionary<double, string>();
                        dic[cityName].Add(cityTemperature, cityWeather);
                    }
                }
            }
            foreach (var cityName in dic.OrderBy(x => x.Value.Keys.Average()))
            {
                foreach (var temper in cityName.Value)
                {
                    Console.WriteLine("{0} => {1:f2} => {2}", cityName.Key, temper.Key, temper.Value);
                }
            }
        }
    }