using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace SongsExerciseForObjectsAndClasses
{
    public class Team
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }

        public List<string> Members;

        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Team> listOfTeams = new List<Team>();
            bool flag = false;

            for (int i = 0; i < numberOfTeams; i++)
            {
                flag = false;

                List<string> UserTeamInput = Console.ReadLine().Split('-').ToList();
                string user = UserTeamInput[0];
                string team = UserTeamInput[1];

                foreach (Team n in listOfTeams)
                {
                    if (team == n.TeamName)
                    {
                        Console.WriteLine($"Team {team} was already created!");
                        flag = true;
                        break;
                    }
                    else if (user == n.Creator)
                    {
                        Console.WriteLine($"{user} cannot create another team!");
                        flag = true;
                        break;
                    }
                }

                if (flag == true)
                {
                    continue;
                }

                Team newTeam = new Team(user, team);
                listOfTeams.Add(newTeam);
                Console.WriteLine($"Team {team} has been created by {user}!");
            }

            string userJoinInput = Console.ReadLine();

            while (userJoinInput != "end of assignment")
            {
                var userArray = userJoinInput.Split("->").ToList();
                string userToJoin = userArray[0];
                string teamToJoin = userArray[1];


                userJoinInput = Console.ReadLine();
            }
        }
    }
}