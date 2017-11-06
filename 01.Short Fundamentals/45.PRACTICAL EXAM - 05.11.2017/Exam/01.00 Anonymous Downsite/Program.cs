using System;
using System.Numerics;  //  100/100
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int securityKey = int.Parse(Console.ReadLine());
        decimal totalLoss = 0M;
       
        for (int i = 0; i < n; i++)
        {
            String[] websiteTokens = Console.ReadLine().Split(' ');
            Console.WriteLine(websiteTokens[0]);

            long siteVisits = long.Parse(websiteTokens[1]);
            decimal siteCommercialIncomePerVisit = decimal.Parse(websiteTokens[2]);

            totalLoss += siteCommercialIncomePerVisit * siteVisits;
        }
        Console.WriteLine("Total Loss: {0:F20}", totalLoss);
        Console.WriteLine("Security Token: {0}", BigInteger.Pow(new BigInteger(securityKey), n));
    }
}