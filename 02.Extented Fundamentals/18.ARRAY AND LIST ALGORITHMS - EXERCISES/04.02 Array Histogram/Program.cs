using System;
using System.Collections.Generic;
using System.Linq;
class Program
    {
        static void Main()
        {
            List<string> statisticsList = Console.ReadLine().Split(' ').ToList();

            List<string> justWords = new List<string>();
            List<int> justTimes = new List<int>();

            int count = 0;
            int additionalCount = 0;

            SplittingTheLists(statisticsList, justWords, justTimes, ref count, ref additionalCount);

            BubblesortMethod(justWords, justTimes);

            Answer(justWords, justTimes);

        }

        static void SplittingTheLists(List<string> statisticsList, List<string> justWords,
            List<int> justTimes, ref int count, ref int additionalCount)
        {
            for (int row = 0; row < statisticsList.Count; row++)
            {
                justWords.Add(statisticsList[row]);
                for (int column = 0; column < statisticsList.Count; column++)
                {
                    if (justWords[additionalCount] == statisticsList[column])
                    {
                        statisticsList.Remove(statisticsList[column]);
                        column--;
                        count++;
                    }
                }
                justTimes.Add(count);
                count = 0;
                additionalCount++;
                row--;
            }
        }

        static void BubblesortMethod(List<string> justWords, List<int> justTimes)
        {
            bool bubbleLamp = false;

            do
            {
                bubbleLamp = false;
                for (int cycle = 0; cycle < justTimes.Count - 1; cycle++)
                {
                    int firstDigit = justTimes[cycle];
                    int secondDigit = justTimes[cycle + 1];

                    string firstWord = justWords[cycle];
                    string secondWord = justWords[cycle + 1];
                    if (secondDigit > firstDigit)
                    {
                        justTimes[cycle] = secondDigit;
                        justTimes[cycle + 1] = firstDigit;
                        justWords[cycle] = secondWord;
                        justWords[cycle + 1] = firstWord;
                        bubbleLamp = true;
                    }
                }
            } while (bubbleLamp);
        }

        static void Answer(List<string> justWords, List<int> justTimes)
        {
            decimal averagePercentage = 100M / justTimes.Sum();
            for (int cycle = 0; cycle < justTimes.Count; cycle++)
            {
                decimal percentage = justTimes[cycle] * averagePercentage;
                Console.WriteLine("{0} -> {1} times ({2:f2}%)",
                    justWords[cycle], justTimes[cycle], percentage);
            }
        }
    }