using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        string searchedKey = Console.ReadLine();
        string searchedValue = Console.ReadLine();

        int n = int.Parse(Console.ReadLine());

        var dic = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; i++)
        {
            var curent = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.None).ToList();

            string curentKey = curent[0];
            
            var allValues = curent[1].Split(';');

            foreach (string curentValue in allValues)
            {
                if (curentKey.Contains(searchedKey) && curentValue.Contains(searchedValue))  // if contains searched key and searched value
                {
                    if (!dic.ContainsKey(curentKey))
                    {
                        dic[curentKey] = new List<string>();
                    }
                    dic[curentKey].Add(curentValue);
                }
            }
        }
        foreach (var key11 in dic)
        {
            Console.WriteLine("{0}:", key11.Key);
            foreach (var key22 in key11.Value)
            {
                Console.WriteLine("-{0}", key22);
            }
        }
    }
}