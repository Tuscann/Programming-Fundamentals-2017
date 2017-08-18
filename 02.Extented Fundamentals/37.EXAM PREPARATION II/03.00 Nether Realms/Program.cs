using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main() // 100/100
    {
        var allDemons = new SortedDictionary<string, List<double>>();

        string[] demonNames = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();

        Regex getNumber = new Regex(@"-?\d*\.?\d+"); // Alternative:  -*[0-9]\.*[0-9]*         [\+\-]*[0-9.]+[0-9]*

        for (int i = 0; i < demonNames.Length; i++)
        {
            string currentDemonName = demonNames[i];
            double currentDemonDamage = 0;

            char[] delimiters = "0123456789*+-/.".ToCharArray();

            int currentDemonHealth = currentDemonName.Where(t => !delimiters.Contains(t)).Sum(t => (int) (t));

            var matchedNumbers = getNumber.Matches(currentDemonName);

            foreach (Match number in matchedNumbers)
            {
                double currentNumber = double.Parse(number.Value);
                currentDemonDamage += currentNumber;
            }

            foreach (char currentSymbol in currentDemonName)
            {
                if (currentSymbol == '*')
                {
                    currentDemonDamage *= 2;
                }
                else if (currentSymbol == '/')
                {
                    currentDemonDamage /= 2;
                }
            }

            if (!allDemons.ContainsKey(currentDemonName))
            {
                allDemons[currentDemonName] = new List<double>();
            }
            allDemons[currentDemonName].Add(currentDemonHealth);
            allDemons[currentDemonName].Add(currentDemonDamage);
        }

        foreach (var demon in allDemons)
        {
            Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
        }
    }
}