using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Project> projects = new List<Project>();

            int countOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] tokans = Console.ReadLine().Split("-");
                string creator = tokans[0];
                string team = tokans[1];

                Project project = new Project
                {
                    Creator = creator,
                    Team = team
                };

                bool containsTeam = projects.Any(t => t.Team == team);
                bool hasGraeted = projects.Any(c => c.Creator == creator);

                if (containsTeam)
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if (hasGraeted)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    projects.Add(project);
                    Console.WriteLine($"Team {team} has been created by {creator}!");
                }
            }
            string[] command = Console.ReadLine().Split("->");

            while (command[0]!="end of assignment")
            {
                string user = command[0];
                string team = command[1];

                bool isExists = projects.Any(t => t.Team == team);
                bool containsUser = projects.Any(u => u.Members.Contains(user));
                bool isCreator = projects.Any(c => c.Creator== user);

                if (!isExists)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (containsUser||isCreator)
                {
                    Console.WriteLine($"Member { user} cannot join team { team}!");
                }
                else
                {
                    foreach (var pr in projects)
                    {
                        if (pr.Team==team && pr.Creator!=user)
                        {
                            pr.Members.Add(user);
                        }
                    }
                }
                command = Console.ReadLine().Split("->");
            }
            foreach (var pr in projects.OrderByDescending(m=>m.Members.Count).ThenBy(t=>t.Team).Where(m=>m.Members.Count>0))
            {
                pr.Members.Sort();
                Console.WriteLine($"{pr.Team}");
                Console.WriteLine($"- {pr.Creator}");
                Console.Write("-- ");
                Console.WriteLine(string.Join("\r\n-- ", pr.Members));
            }
            Console.WriteLine("Teams to disband:");

            foreach (var pr in projects.OrderBy(t => t.Team).Where(m => m.Members.Count < 1))
            {
                Console.WriteLine($"{ pr.Team}");
            }
        }
    }
    class Project
    {
        public List<string> Members = new List<string>();
        public string Creator { get; set; }
        public string Team { get; set; }
    }
}
