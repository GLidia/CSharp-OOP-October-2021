using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_FootballTeamGeneratorAgain
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(";", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Team")
                {
                    Team team = new Team(command[1]);
                    teams.Add(team);
                }
                else if (command[0] == "Add")
                {
                    if (!teams.Any(x => x.Name == command[1]))
                    {
                        Console.WriteLine($"Team {command[1]} does not exist.");
                    }
                    else
                    {
                        Team teamToWhichToAdd = teams.Where(x => x.Name == command[1]).First();
                        try
                        {
                            Player player = new Player(command[2], int.Parse(command[3]), int.Parse(command[4]), int.Parse(command[5]), int.Parse(command[6]), int.Parse(command[7]));
                            teamToWhichToAdd.AddPlayer(player);
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (!teams.Any(x => x.Name == command[1]))
                    {
                        Console.WriteLine($"Team {command[1]} does not exist.");
                    }
                    else
                    {
                        try
                        {
                            Team teamFromWhichToRemove = teams.Where(x => x.Name == command[1]).First();
                            teamFromWhichToRemove.RemovePlayer(command[2]);
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                    }
                }
                else if (command[0] == "Rating")
                {
                    if (!teams.Any(x => x.Name == command[1]))
                    {
                        Console.WriteLine($"Team {command[1]} does not exist.");
                    }
                    else
                    {
                        Team teamWhoseRatingToShow = teams.Where(x => x.Name == command[1]).First();
                        Console.WriteLine($"{teamWhoseRatingToShow.Name} - {teamWhoseRatingToShow.Rating:F0}");
                    }
                }
            }
        }
    }
}
