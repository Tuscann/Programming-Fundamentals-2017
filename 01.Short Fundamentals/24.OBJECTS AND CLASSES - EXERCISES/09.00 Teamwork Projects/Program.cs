using System;
using System.Collections.Generic;  // 100/100
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Teamwork_projects
{
    class Program
    {
        static void Main()
        {
            var teams = new List<Team>();
            var joinedMembers = new List<string>();

            int nOfTeams = int.Parse(Console.ReadLine());
            for (int i = 0; i < nOfTeams; i++)
            {
                var tokens = Console.ReadLine().Split('-').ToArray();
                var creator = tokens[0];
                var teamToCreate = tokens[1];

                if(teams.Any(x=>x.teamName == teamToCreate))
                {
                    Console.WriteLine($"Team {teamToCreate} was already created!");
                    continue;
                }

                if (teams.Any(x => x.creatorName == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                teams.Add(new Team(teamToCreate, creator));
                joinedMembers.Add(creator);
                Console.WriteLine($"Team {teamToCreate} has been created by {creator}!");
            }
            string input = Console.ReadLine();
            while(input!= "end of assignment")
            {
                var tokens = input.Split(new string[] { "->" },StringSplitOptions.None).ToArray();
                var name = tokens[0];
                var teamToJoin = tokens[1];

                if(!teams.Any(x=>x.teamName == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    input = Console.ReadLine();
                    continue;
                }

                if (joinedMembers.Contains(name))
                {
                    Console.WriteLine($"Member {name} cannot join team {teamToJoin}!");
                    input = Console.ReadLine();
                    continue;
                }

                teams.Single(x => x.teamName == teamToJoin).teamMembers.Add(name);
                joinedMembers.Add(name);

                input = Console.ReadLine();
            }

            foreach (var team in teams.OrderByDescending(x=>x.teamMembers.Count).ThenBy(x=>x.teamName))
            {
                if(team.teamMembers.Count> 0)
                {
                    Console.WriteLine(team.teamName);
                    Console.WriteLine("- "+team.creatorName);
                    foreach (var member in team.teamMembers.OrderBy(x=>x))
                    {
                        Console.WriteLine("-- "+member);
                    }
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teams.Where(x=>x.teamMembers.Count == 0).OrderBy(x=>x.teamName))
            {
                Console.WriteLine(item.teamName);
            }
            //Console.ReadLine();
        }
    }

    public class Team
    {
        public string teamName;
        public string creatorName;
        public List<string> teamMembers = new List<string>();
        public Team(string TeamName, string CreatorName)
        {
            this.teamName = TeamName;
            this.creatorName = CreatorName;
        }
    }
}