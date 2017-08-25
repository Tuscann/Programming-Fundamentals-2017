using System;
using System.Collections.Generic;
public class ShootListElements
{
    public static void Main()
    {
        string userInput = Console.ReadLine();

        List<int> numbersToShoot = new List<int>();
        ConsoleOutpute(userInput, numbersToShoot);
    }

    private static string ConsoleOutpute(string userInput, List<int> numbersToShoot)
    {
        while (userInput != "stop")
        {
            int number;
            int shotingNumber = 0;

            if (int.TryParse(userInput, out number))
            {
                numbersToShoot.Insert(0, number);
            }
            else if (userInput == "bang")
            {
                if (numbersToShoot.Count > 0)
                {
                    double average = GetAverageSumOfTheElements(numbersToShoot);

                    for (int i = 0; i < numbersToShoot.Count; i++)
                    {
                        shotingNumber = numbersToShoot[i];

                        if (shotingNumber <= average)
                        {
                            Console.WriteLine($"shot {shotingNumber}");
                            numbersToShoot.RemoveAt(i);
                            DecrementAllNumbersLeftInIt(numbersToShoot);
                            break;
                        }
                    }
                }
            }
            userInput = Console.ReadLine();

            if (userInput == "stop" && numbersToShoot.Count == 0)
            {
                Console.WriteLine($"you shot them all. last one was {shotingNumber}");
            }

            else if (numbersToShoot.Count == 0)
            {
                Console.WriteLine($"nobody left to shoot! last one was {shotingNumber}");
                break;
            }
        }
        if (numbersToShoot.Count > 0)
        {
            string result = string.Join(" ", numbersToShoot);
            Console.WriteLine($"survivors: {result}");
        }
        return userInput;
    }

    static List<int> DecrementAllNumbersLeftInIt(List<int> numbersToShoot)
    {
        for (int i = 0; i < numbersToShoot.Count; i++)
        {
            numbersToShoot[i]--;
        }
        return numbersToShoot;
    }

    static double GetAverageSumOfTheElements(List<int> numbersToShoot)
    {
        int sum = 0;
        int len = numbersToShoot.Count;

        foreach (int num in numbersToShoot)
        {
            sum += num;
        }
        double averageSum = (double)sum / len;

        return averageSum;
    }
}