using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] racers = Console.ReadLine().Split(' ').ToArray();
        float[] terrLayout = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
        int[] checkPoints = Console.ReadLine().Split(' ').Select(int.Parse).Select(x => Math.Abs(x)).ToArray();

        foreach (var racer in racers)
        {
            string message = "";
            float fuel = racer[0];
            int checkPointsCounter = 0;

            for (int i = 0; i < terrLayout.Length; i++)
            {
                bool isEqual = false;

                for (int k = 0; k < checkPoints.Length; k++)
                {
                    if (i == checkPoints[k])
                    {
                        isEqual = true;
                        break;
                    }
                }

                if (isEqual)
                {
                    fuel += terrLayout[i];
                }
                else
                {
                    fuel -= terrLayout[i];
                }

                if (fuel > 0)
                {
                    checkPointsCounter++;
                }
                else
                {
                    message = $"{racer} - reached {checkPointsCounter}";
                    Console.WriteLine(message);
                    break;
                }

            }

            if (fuel > 0)
            {
                message = $"{racer} - fuel left {fuel:f2}";
                Console.WriteLine(message);
            }
        }
    }
}
