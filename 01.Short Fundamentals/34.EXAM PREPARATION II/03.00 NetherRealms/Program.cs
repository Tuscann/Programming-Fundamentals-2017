using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main() 
    {
        List<string> input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        
        Dictionary<string, Dictionary<double, double>> dic = new Dictionary<string, Dictionary<double,double>>();

        double health = 0;
        double damage = 0;

        foreach (string row in input)
        {
            health = 0;
            damage = 0;
            string patternDigits = @"([+|-]?[0-9]{1,}\.?[0-9]?)([*\/]*)";
            string patternStrings = @"[A-Za-z]";

            MatchCollection matchesStrings = Regex.Matches(row, patternStrings);
            MatchCollection matchesDigits = Regex.Matches(row, patternDigits);

            string sign = String.Empty;
            foreach (Match stringg in matchesStrings)
            {
                char[] x = stringg.ToString().ToCharArray();
                health += x[0];
            }
            foreach (Match stringg in matchesDigits)
            {
                damage += double.Parse(stringg.Groups[1].ToString());
                sign = stringg.Groups[2].ToString();
            }
            
            if (!dic.ContainsKey(row))
            {
                if (sign=="*")
                {
                    dic[row] = new Dictionary<double, double>();
                    dic[row].Add(health, damage * 2 * 2);
                }
                if (sign=="/")
                {
                    dic[row] = new Dictionary<double, double>();
                    dic[row].Add(health, damage / 2 / 2);
                }
            }
        }
        foreach (KeyValuePair<string, Dictionary<double, double>> row in dic.OrderBy(x => x.Key))
        {
            Console.Write("{0} - ", row.Key);
            foreach (KeyValuePair<double, double> digits in row.Value)
            {
                Console.Write("{0} health, {1:f2} damage", digits.Key, digits.Value);
            }
            Console.WriteLine();
        }
    }
}