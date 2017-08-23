using System;
class Program
{
    static void Main() // 100/100
    {
        decimal PriceUS = decimal.Parse(Console.ReadLine()) / (decimal)0.58;
        decimal boxWeightUS = decimal.Parse(Console.ReadLine());
        decimal PriceUK = decimal.Parse(Console.ReadLine()) / (decimal)0.41;
        decimal boxWeightUK = decimal.Parse(Console.ReadLine());
        decimal PriceChina = decimal.Parse(Console.ReadLine()) * (decimal)0.27;
        decimal boxWeightChina = decimal.Parse(Console.ReadLine());

        decimal totalUS = PriceUS / boxWeightUS;
        decimal totalUK = PriceUK / boxWeightUK;
        decimal totalChina = PriceChina / boxWeightChina;

        decimal maxx = Math.Max(totalUS, Math.Max(totalUK, totalChina));
        decimal min = Math.Min(totalUS, Math.Min(totalUK, totalChina));
        
        if (min == totalUS)
        {
            Console.WriteLine("US store. {0:f2} lv/kg", min);
        }
        else if (min == totalUK)
        {
            Console.WriteLine("UK store. {0:f2} lv/kg", min);
        }
        else
        {
            Console.WriteLine("Chinese store. {0:f2} lv/kg", min);
        }
        Console.WriteLine("Difference {0:f2} lv/kg", maxx - min);
    }
}