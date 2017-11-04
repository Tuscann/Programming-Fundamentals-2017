using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;   // 100/100
class Demon 
{
    public string Name { get; set; }
    public int Health { get; set; }
    public double Damage { get; set; }
}

class Program
{
    static void Main()
    {
        string[] demons = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
        List<Demon> res = new List<Demon>();
        Regex check = new Regex(@"-?\d+\.?\d*");
        Demon dem = new Demon();
        foreach (var demon in demons)
        {
            dem = new Demon();
            int health = 0;
            foreach (var item in demon.Where(x => !char.IsDigit(x) && x != '+' && x != '-' && x != '*' && x != '/' && x != '.'))
            {
                health += item;
            }
            double damage = 0.0;
            foreach (Match match in check.Matches(demon))
            {
                damage += double.Parse(match.Value);
            }
            foreach (var item in demon)
            {
                if (item == '*')
                {
                    damage *= 2;
                }
                else if (item == '/')
                {
                    damage /= 2;
                }
            }
            dem.Health = health;
            dem.Damage = damage;
            dem.Name = demon;
            res.Add(dem);
        }

        foreach (var item in res.OrderBy(x => x.Name))
        {
            Console.WriteLine("{0} - {1} health, {2:f2} damage", item.Name, item.Health, item.Damage);
        }
    }
}