using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, Dictionary<string, bool>>> dic = new Dictionary<string, Dictionary<string, Dictionary<string, bool>>>();

        while (true)
        {
            string x = Console.ReadLine();
            if (x == "end")
            {
                break;
            }
            string[] curentRow = x.Split();

            string tv = curentRow[0];
            string model = curentRow[1];
            string place = curentRow[2];

            if (!dic.ContainsKey(tv))
            {
                dic[tv] = new Dictionary<string, Dictionary<string, bool>>();
                dic[tv][model][place] = true;
            }
            if (!dic[tv].ContainsKey(model))
            {
                dic[tv][model] = new Dictionary<string, bool>();
                dic[tv][model][place] = true;
            }
            if (!dic[tv][model].ContainsKey(place))
            {
                dic[tv][model][place] = true;
            }




            if (curentRow[0] == "flatten")
            {

            }

        }
        int counter = 1;

        foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, bool>>> tv in dic.OrderByDescending(x => x.Value))
        {
            Console.WriteLine("{0}", tv.Key);
            foreach (KeyValuePair<string, Dictionary<string, bool>> model in tv.Value.OrderBy(x => x.Key.Length))
            {
                foreach (KeyValuePair<string, bool> place in model.Value)
                {
                    Console.WriteLine("{0}. {1} - {2}", counter, place.Key, place.Value);
                    counter++;
                }
            }
        }



    }
}

