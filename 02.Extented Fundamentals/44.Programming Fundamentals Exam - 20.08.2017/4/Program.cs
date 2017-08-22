using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        var dictio = new Dictionary<string, Dictionary<string, int>>();
        while (true)
        {
            string cuurent = Console.ReadLine();
            if (cuurent == "It's Training Men!")
            {
                break;
            }
            string[] inputsss = cuurent.Split().ToArray();

            string trainName = inputsss[0];
            if (!dictio.ContainsKey(trainName))
            {
                dictio[trainName] = new Dictionary<string, int>();
            }
            if (inputsss[1].Trim() == "->" && inputsss.Length == 3)
            {
                string otherTrainName = inputsss[2];
                Dictionary<string, int> curentttt = dictio[otherTrainName];

                foreach (var key in curentttt)
                {
                    dictio[trainName].Add(key.Key, key.Value);
                }
                dictio.Remove(otherTrainName);

            }
            if (inputsss[1].Trim() == "->" && inputsss.Length > 3)   // zapisavame sashtite vagoni na drugiq i mahame
            {
                string wagonName = inputsss[2];
                int wagonPower = int.Parse(inputsss[4]);

                dictio[trainName].Add(wagonName, wagonPower); ;
            }

            if (inputsss[1].Trim() == "=")  // zapisavame sashtite vagoni na drugiq
            {
                string otherTrainName = inputsss[2];
                Dictionary<string, int> curentttt = dictio[otherTrainName];
                
                dictio[trainName].Clear();

                foreach (var key in curentttt)
                {
                    dictio[trainName].Add(key.Key, key.Value);
                }
            }
        }
        foreach (var trainNamess in dictio.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Count))
        {
            Console.WriteLine("Train: {0}", trainNamess.Key);
            foreach (var wagonn in trainNamess.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("###{0} - {1}", wagonn.Key, wagonn.Value);
            }
        }
    }
}