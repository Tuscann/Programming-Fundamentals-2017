using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var dic = new Dictionary<int, Dictionary<string, List<string>>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Time for Code")
            {
                break;
            }
            var array = input.Split().ToList();
            int num1 = 0;

            if (int.TryParse(array[0], out num1) && array[1].Contains('#'))
            {
                if (!dic.ContainsKey(int.Parse(array[0])))
                {
                    dic[int.Parse(array[0])] = new Dictionary<string, List<string>>();
                }

                if (dic.ContainsKey(int.Parse(array[0])) && !dic[int.Parse(array[0])].ContainsKey(array[1]))
                {
                    dic[int.Parse(array[0])].Remove(array[1]);
                    dic[int.Parse(array[0])] = new Dictionary<string, List<string>>();
                    dic[int.Parse(array[0])].Add(array[1], new List<string>());

                    for (int i = 2; i < array.Count; i++)
                    {
                        if (array[i].Contains('@'))
                        {
                            dic[int.Parse(array[0])][array[1]].Add(array[i]);
                        }
                    }

                }

            }
        }
        foreach (var words in dic)
        {
            Console.WriteLine(words.Value.Values.Count);
            foreach (var word in words.Value.OrderByDescending(a => a.Value.Count).ThenBy(a => a.Key))
            {
                word.Value.Sort();
                Console.WriteLine("{0} - {1}", word.Key.Substring(1, word.Key.Length - 1), word.Value.Count);
               
                Console.WriteLine("{0}", string.Join("\n", word.Value));
            }
        }




    }
}