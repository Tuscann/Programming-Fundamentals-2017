using System;
using System.Collections.Generic;  // 87/100
using System.Linq;

namespace TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main()
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            Team currentTeam = new Team("","",new List<string>());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split('-');
                string currentCreatorName = inputLine[0];
                string currentTeamName = inputLine[1];
                
                //I have to make new list for members or I have null value exeption.List must have count 0.
                List<string> membersList = new List<string>();

                currentTeam = new Team(currentTeamName, currentCreatorName, membersList);

                //Team  doesn't contains creator name.
                if (!teams.Values.Any(x => x.TeamName.Equals(currentTeamName)))
                {
                    currentTeam.TeamName = currentTeamName;
                 
                    //If Team -> team name - doesn't contains current team name.
                    if (!teams.Values.Any(x => x.TeamName.Equals(currentTeamName)))
                    {
                        teams.Add(currentCreatorName, currentTeam);
                        Console.WriteLine($"Team {currentTeamName} has been created by {currentCreatorName}!");
                    }
                    else
                    {
                        //Team Team -> team name - contains current team name.
                        Console.WriteLine($"{currentCreatorName} cannot create another team!");
                    }
                }
                else
                {
                    //Team contains creator name.
                    Console.WriteLine("Team {0} was already created!", currentTeamName);
                }

            }

            string secondInput = Console.ReadLine();
            while (!secondInput.Equals("end of assignment"))
            {
                string[] inputArgs = secondInput.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currentUser = inputArgs[0];
                string teamToJoin = inputArgs[1];

                //If list of teams does contains team name and current user want to join  -> teamToJoin. 
                if (teams.Values.Any(x => x.TeamName.Equals(teamToJoin)))
                {
                    //If teamToJoin doesn't contains members equal to current user 
                    //AND if teamToJoin doesn't contains creator name equal to current user.
                    if (!teams.Values.Any(c => c.Members.Any(x => x.Equals(currentUser))) && !teams.Values.Any(c => c.CreatorName.Equals(currentUser)))
                    {
                        var creatorOfTheTeam = teams.First(x => x.Value.TeamName.Equals(teamToJoin));
                        teams[creatorOfTheTeam.Key].Members.Add(currentUser);                         
                    }
                    else
                    {
                        //If teamToJoin does contains member equal to current user
                        //OR teamToJoin does contains creator name equal to currentUser.
                        Console.WriteLine("Member {0} cannot join team {1}!", currentUser, teamToJoin);
                    }
                }
                else
                {
                    //If list of teams doesn't contains team name.
                    Console.WriteLine("Team {0} does not exist!", teamToJoin);
                }

                secondInput = Console.ReadLine();
            }

            foreach (var team in teams.Values.Where(c => c.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(c => c.TeamName))
            {
                Console.WriteLine("{0}", team.TeamName);
                Console.WriteLine("- {0}", team.CreatorName);

                foreach (var member in team.Members.OrderBy(x=>x))
                {
                    Console.WriteLine("-- {0}", member);
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var teamToDisband in teams.Where(c => c.Value.Members.Count == 0).OrderBy(x => x.Value.TeamName))
            {              
                Console.WriteLine($"{teamToDisband.Value.TeamName}");
            }

        }
    }

    class Team
    {
        private string teamName;

        private string creatorName;

        private List<string> members; 


        public Team(string teamName, string creatorName, List<string> members)
        {
            this.teamName = teamName;
            this.creatorName = creatorName;
            this.members = members;
        }

        public Team(string teamName, string creatorName) : this(teamName, creatorName, null)
        {

        }

        public Team(string teamName) : this(teamName, null, null)
        {

        }

        public string TeamName
        {
            get
            {
                return teamName;
            }
            set
            {
                value = teamName;
            }
            
        }

        public string CreatorName
        {
            get
            {
                return creatorName;
            }
            set
            {
                value = creatorName;
            }
        }

        public List<string> Members
        {
            get
            {
                return members;
            }
            set
            {
                value = members;
            }
        }
    }
}