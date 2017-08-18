using System;
class P10_PriceChangeAlert
{
    static void Main() // 100/100
    {
        int pricesCount = int.Parse(Console.ReadLine());
        double significanceThreshold = double.Parse(Console.ReadLine()) * 100.0;
        double previousPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < pricesCount - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double percentageDiffernce = GetPercentageDiffernce(previousPrice, currentPrice);
            bool isSignificantDifference = IsThereSignificantDifference(percentageDiffernce, significanceThreshold);
            string message = GetMessage(currentPrice, previousPrice, percentageDiffernce, isSignificantDifference);
            Console.WriteLine(message);
            previousPrice = currentPrice;
        }
    }

    private static string GetMessage(double currentPrice, double previousPrice, double percentageDiffernce, bool isSignificantDifference)
    {
        if (percentageDiffernce == 0)
        {
            return string.Format("NO CHANGE: {0}", currentPrice);
        }
        if (!isSignificantDifference)
        {
            return string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, percentageDiffernce);
        }
        if (isSignificantDifference && (percentageDiffernce > 0))
        {
            return string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, percentageDiffernce);
        }
        return string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, percentageDiffernce);
    }

    private static bool IsThereSignificantDifference(double percentageDiffernce, double significanceThreshold)
    {
        if (Math.Abs(percentageDiffernce) >= significanceThreshold)
        {
            return true;
        }
        return false;
    }

    private static double GetPercentageDiffernce(double previousPrice, double currentPrice)
    {
        double percentageDiffernce = (currentPrice - previousPrice) / previousPrice * 100.0;
        return percentageDiffernce;
    }
}