using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        long[] priceRating = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long entryPolong = long.Parse(Console.ReadLine());
        string itemType = Console.ReadLine();
        string priceRatingType = Console.ReadLine();

        long sumLeft = 0;
        long sumRight = 0;
        for (long i = 0; i < entryPolong; i++)
        {
            if (itemType == "cheap" && priceRatingType == "positive")
            {
                if (priceRating[i] < priceRating[entryPolong] && priceRating[i] > 0)
                    sumLeft += priceRating[i];
            }
            else if (itemType == "cheap" && priceRatingType == "negative")
            {
                if (priceRating[i] < priceRating[entryPolong] && priceRating[i] < 0)
                    sumLeft += priceRating[i];
            }
            else if (itemType == "cheap" && priceRatingType == "all")
            {
                if (priceRating[i] < priceRating[entryPolong])
                    sumLeft += priceRating[i];
            }
            else if (itemType == "expensive" && priceRatingType == "positive")
            {
                if (priceRating[i] >= priceRating[entryPolong] && priceRating[i] > 0)
                    sumLeft += priceRating[i];
            }
            else if (itemType == "expensive" && priceRatingType == "negative")
            {
                if (priceRating[i] >= priceRating[entryPolong] && priceRating[i] < 0)
                    sumLeft += priceRating[i];
            }
            else if (itemType == "expensive" && priceRatingType == "all")
            {
                if (priceRating[i] >= priceRating[entryPolong])
                    sumLeft += priceRating[i];
            }
        }

        for (long i = entryPolong + 1; i < priceRating.Length; i++)
        {
            if (itemType == "cheap" && priceRatingType == "positive")
            {
                if (priceRating[i] < priceRating[entryPolong] && priceRating[i] > 0)
                    sumRight += priceRating[i];
            }
            else if (itemType == "cheap" && priceRatingType == "negative")
            {
                if (priceRating[i] < priceRating[entryPolong] && priceRating[i] < 0)
                    sumRight += priceRating[i];
            }
            else if (itemType == "cheap" && priceRatingType == "all")
            {
                if (priceRating[i] < priceRating[entryPolong])
                    sumRight += priceRating[i];
            }
            else if (itemType == "expensive" && priceRatingType == "positive")
            {
                if (priceRating[i] >= priceRating[entryPolong] && priceRating[i] > 0)
                    sumRight += priceRating[i];
            }
            else if (itemType == "expensive" && priceRatingType == "negative")
            {
                if (priceRating[i] >= priceRating[entryPolong] && priceRating[i] < 0)
                    sumRight += priceRating[i];
            }
            else if (itemType == "expensive" && priceRatingType == "all")
            {
                if (priceRating[i] >= priceRating[entryPolong])
                    sumRight += priceRating[i];
            }
        }
        if (sumLeft >= sumRight)
            Console.WriteLine("Left - {0}", sumLeft);
        else
            Console.WriteLine("Right - {0}", sumRight);
    }
}