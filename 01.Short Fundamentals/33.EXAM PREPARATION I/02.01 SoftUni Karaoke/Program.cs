using System;
using System.Collections.Generic;
using System.Linq;
class Singer
{
    public string Name { get; set; }
    public List<string> Songs { get; set; }
    public List<string> Awards { get; set; }

    public Singer()
    {
        Songs = new List<string>();
        Awards = new List<string>();
    }
}
class SoftUniKaraoke
{
    static void Main()
    {
        List<Singer> singers = new List<Singer>();
        List<string> givenAwards = new List<string>();

        string[] inputSingers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] inputSongs = Console.ReadLine().Split(',');
        List<string> songs = new List<string>();

        foreach (string song in inputSongs)
        {
            songs.Add(song.Trim());
        }

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "dawn") break;

            string[] inputArgs = input.Split(',');
            string currentSinger = inputArgs[0].Trim();
            string currentSong = inputArgs[1].Trim();
            string currentAward = inputArgs[2].Trim();

            if (!inputSingers.Contains(currentSinger)) continue;

            if (!songs.Contains(currentSong)) continue;

            Singer curr = new Singer();
            if (singers.Any(x => x.Name == currentSinger))
            {
                curr = singers.First(x => x.Name == currentSinger);
                if (!curr.Songs.Contains(currentSong))
                {
                    curr.Songs.Add(currentSong);
                }
                if (!curr.Awards.Contains(currentAward) && !givenAwards.Contains(currentAward))
                {
                    curr.Awards.Add(currentAward);
                }
            }
            else
            {
                curr = new Singer();
                curr.Name = currentSinger;
                curr.Songs.Add(currentSong);
                if (!givenAwards.Contains(currentAward))
                {
                    curr.Awards.Add(currentAward);
                }
                singers.Add(curr);
            }

            givenAwards.Add(currentAward);
        }

        foreach (Singer singer in singers.OrderByDescending(x => x.Awards.Count).ThenBy(x => x.Name))
        {
            Console.WriteLine("{0}: {1} awards", singer.Name, singer.Awards.Count);
            foreach (string award in singer.Awards.OrderBy(x => x))
            {
                Console.WriteLine("--{0}", award);
            }
        }

        if (singers.Count == 0)
        {
            Console.WriteLine("No awards");
        }
    }
}
