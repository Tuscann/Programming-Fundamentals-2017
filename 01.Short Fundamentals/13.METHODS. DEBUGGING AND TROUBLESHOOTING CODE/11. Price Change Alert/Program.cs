using System;
class Program
    {
        static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());

                double contrast = Percentage(lastPrice, currentPrice);
                bool isSignificantDifference = Contrast(contrast, threshold);
                string message = Get(currentPrice, lastPrice, contrast, isSignificantDifference);
                Console.WriteLine(message);
                lastPrice = currentPrice;
            }
        }

        public static string Get(double currentPrice, double lastPrice, double contrast, bool etherTrueOrFalse)
        {
            string result = string.Empty;

            if (contrast == 0)
            {
                result = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!etherTrueOrFalse)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, contrast * 100);
            }
            else if (contrast > 0)
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, contrast * 100);
            }
            else if (contrast < 0)
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, contrast * 100);

            return result;
        }

        private static bool Contrast(double threshold, double price)
        {
            if (Math.Abs(threshold) >= price)
            {
                return true;
            }
            return false;
        }

        private static double Percentage(double lastPrice, double currentPrice)
        {
            double result = (currentPrice - lastPrice) / lastPrice;
            return result;
        }
    }