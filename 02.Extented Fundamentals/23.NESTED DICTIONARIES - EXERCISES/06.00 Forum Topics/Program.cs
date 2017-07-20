using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._00_Forum_Topics
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();


            while (true)
            {
                string x = Console.ReadLine();
                if (x == "filter")
                {
                    break;
                }
                List<string> cuurent = x.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string topic = cuurent[0];
                List<string> allTags = cuurent[1].Split(new[] { ",", ", ", " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!dic.ContainsKey(topic))
                {
                    dic[topic] = new List<string>();
                }
                dic[topic].AddRange(allTags);
            }
            List<string> serachedTopics = Console.ReadLine().Split().ToList();


            foreach (var topic in dic)
            {
                var contains = true;

                foreach (var tag in topic.Value.Distinct())
                {
                    foreach (var searchedTopic in serachedTopics)
                    {
                        if (!tag.Contains(searchedTopic))
                        {
                            contains = false;
                        }
                    }
                }
                if (contains == false)
                {
                    Console.Write("{0} | ", topic.Key);

                    Console.WriteLine("{0}", string.Join(", ", topic.Value.Distinct()));
                }
                else
                {
                    Console.WriteLine(1);
                }
            }
           
        }

    }
}