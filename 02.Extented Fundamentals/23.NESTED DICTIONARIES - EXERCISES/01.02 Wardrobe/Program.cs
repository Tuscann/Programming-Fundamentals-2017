using System;
using System.Collections.Generic;
class Program
    {
        static void Main()  // 100/100
        {
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            string key = Console.ReadLine();
            string value = Console.ReadLine();
            int inputCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCnt; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

                string firstWord = inputTokens[0];
                string[] nextWords = inputTokens[1].Split(';');

                if (firstWord.Contains(key))
                {
                    if (!data.ContainsKey(firstWord))
                    {
                        data[firstWord] = new List<string>();
                    }

                    foreach (string word in nextWords)
                    {
                        if (word.Contains(value))
                        {
                            data[firstWord].Add(word);
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, List<string>> words in data)
            {
                Console.WriteLine($"{words.Key}:");

                foreach (string word in words.Value)
                {
                    Console.WriteLine($"-{word}");
                }
            }
        }
    }