using System;
using System.Linq;
using System.Text.RegularExpressions;
class RealmsMain
{
    static void Main()  // 100/100
    {
        string[] demons = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(d => d).ToArray();

        foreach (string demon in demons)
        {
            double demonHealth = GetDemonHealth(demon);
            decimal demonDamage = GetDemonDamage(demon);
            Console.WriteLine($"{demon} - {demonHealth} health, {demonDamage:F2} damage");
        }
    }

    private static decimal GetDemonDamage(string demon)
    {
        string demontDamagePattern = @"[\-\+]?[\d]+(?:[\.]*[\d]*)";
        Regex regex = new Regex(demontDamagePattern);
        MatchCollection collection = regex.Matches(demon);
        decimal damage = 0;
        foreach (var number in collection)
        {
            damage += decimal.Parse(number.ToString());
        }

        foreach (char c in demon.Where(c => c == '*' || c == '/'))
        {
            if (c == '*')
            {
                damage *= 2;
            }
            else
            {
                damage /= 2;
            }
        }

        return damage;
    }

    private static double GetDemonHealth(string demon)
    {
        string demonHealthPattern = @"[^\d\.\+\-\*\/\s\,]";
        MatchCollection collection = Regex.Matches(demon, demonHealthPattern);
        double health = 0;
        foreach (Match str in collection)
        {
            char[] x = str.ToString().ToCharArray();
            health += x[0];
        }
        return health;
    }
}
