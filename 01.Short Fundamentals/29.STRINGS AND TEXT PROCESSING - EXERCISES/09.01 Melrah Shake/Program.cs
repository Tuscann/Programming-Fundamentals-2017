using System;
using System.Collections.Generic;
class Program
    {
        static void Main() // 100/100
        {
            string randomChars = Console.ReadLine();
            string pattern = Console.ReadLine();

            List<int> listOfIndexes = new List<int>();

            while (true)
            {
                int patternLength = pattern.Length;

                if (patternLength < 1)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(randomChars);
                    break;
                }

                int continueIndex = 0;
                int index = 0;
                int count = -1;

                while (index != -1)
                {
                    index = randomChars.IndexOf(pattern, continueIndex);
                    continueIndex = index + 1;
                    count++;
                    listOfIndexes.Add(index);
                }

                if (count < 2 || patternLength < 1)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(randomChars);
                    break;
                }
                Console.WriteLine("Shaked it.");
                randomChars = randomChars.Remove(listOfIndexes[listOfIndexes.Count - 2], patternLength);
                randomChars = randomChars.Remove(listOfIndexes[0], patternLength);
                pattern = pattern.Remove(patternLength / 2, 1);


                listOfIndexes.Clear();
            }
        }
    }