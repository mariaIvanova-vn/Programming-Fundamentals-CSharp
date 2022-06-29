using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public Team(string teamName,string creatorName)
        {
            this.Name = teamName;
            this.Creator = creatorName;
            this.Members = new List<string>();
        }
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
        public void AddMember(string member)
        {
            this.Members.Add(member);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] teamArg = Console.ReadLine().Split("-").ToArray();
                string creatorName = teamArg[0];
                string teamName = teamArg[1];

                if (teams.Any(t=>t.Name==teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(t => t.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            string command;
            while ((command=Console.ReadLine())!= "end of assignment")
            {
                string[] joinArg = command.Split("->").ToArray();
                string memberName = joinArg[0];
                string teamName = joinArg[1];
                Team team = teams.FirstOrDefault(t => t.Name == teamName);
                if (team==null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (IsAlreadyMemberOfTeam(teams,memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }
                if (teams.Any(t=>t.Creator==memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }
                team.AddMember(memberName);
            }
            List<Team> teamWithMember = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name).ToList(); 
            List<Team> teamToDisband = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Name).ToList();
            foreach (Team validTeam in teamWithMember)
            {
                Console.WriteLine($"{validTeam.Name}");
                Console.WriteLine($"- {validTeam.Creator}");
                foreach (var member in validTeam.Members.OrderBy(m=>m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team invalidTeam in teamToDisband)
            {
                Console.WriteLine($"{invalidTeam.Name}");
            }
        }


        static bool IsAlreadyMemberOfTeam(List<Team> teams,string memberName)
        {
            foreach (Team item in teams)
            {
                if (item.Members.Contains(memberName))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
