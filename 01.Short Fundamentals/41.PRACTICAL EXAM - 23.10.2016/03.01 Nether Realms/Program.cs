using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string[] demonNames = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, demon> demons = new Dictionary<string, demon>();

        foreach (var demonName in demonNames)
        {
            string pattern = @"(\-|\+)*([0-9]+\.)*[0-9]+";
            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(demonName);

            double sum = 0;

            foreach (Match match in matchCollection)
            {
                double num = double.Parse(match.ToString());
                sum += num;
            }

            string pattern1 = @"\*";
            Regex regex1 = new Regex(pattern1);

            MatchCollection matchCollection1 = regex1.Matches(demonName);

            foreach (Match match1 in matchCollection1)
            {
                sum *= 2;
            }

            string pattern3 = @"\/";
            Regex regex3 = new Regex(pattern3);

            MatchCollection matchCollection3 = regex3.Matches(demonName);

            foreach (Match match3 in matchCollection3)
            {
                sum /= 2;
            }

            int sumHealth = 0;

            string pattern2 = @"[^\d\.\+\-\*\/]+";
            Regex regex2 = new Regex(pattern2);

            MatchCollection matchCollection2 = regex2.Matches(demonName);

            foreach (Match match2 in matchCollection2)
            {
                char[] symbols = match2.ToString().ToCharArray();

                foreach (var symbol in symbols)
                {
                    int num = symbol;
                    sumHealth += num;
                }
            }

            demon participant = new demon();
            participant.damage = sum;
            participant.health = sumHealth;

            demons.Add(demonName, participant);
        }

        foreach (var demonName in demons.OrderBy(x => x.Key))
        {

            Console.WriteLine("{0} - {1} health, {2:f2} damage", demonName.Key, demonName.Value.health, demonName.Value.damage);
        }
    }
}

public class demon
{
    public double health { get; set; }
    public double damage { get; set; }
}
