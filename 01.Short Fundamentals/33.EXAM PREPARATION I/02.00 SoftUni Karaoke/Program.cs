using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var partisiments = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToList();
        var songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToList();
        var dic = new Dictionary<string, List<string>>();

        bool isAwarded = true;
        
        while (true)
        {
            string x = Console.ReadLine();
            if (x == "dawn")
            {
                break;
            }
            var curentSongs = x.Split(new string[] { ", " }, StringSplitOptions.None).ToList();
            string participant = curentSongs[0];
            string song = curentSongs[1];
            string award = curentSongs[2];


            if (songs.Contains(song) && partisiments.Contains(participant))
            {
                if (!dic.ContainsKey(participant))
                {
                    dic[participant] = new List<string>();
                }
                if (dic[participant].Contains(award))
                {
                    dic[participant].Remove(award);
                }
                dic[participant].Add(award);
                isAwarded = false;
            }
        }
        if (isAwarded)
        {
            Console.WriteLine("No awards");
        }
        else
        {
            foreach (var name in dic.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine("{0}: {1} awards", name.Key, name.Value.Count);
                foreach (var song in name.Value.OrderBy(a => a))
                {
                    Console.WriteLine("--{0}", song);
                }
            }
        }
    }
}