using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_FootballTeamGeneratorAgain
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public double Rating
        {
            get
            {
                return this.CalculateRating();
            }
        }

        private double CalculateRating()
        {
            if (players.Count == 0)
            {
                return 0;
            }

            double totalPoints = 0.0;
            foreach (Player player in this.players)
            {
                totalPoints += (player.Endurance + player.Dribble + player.Passing + player.Shooting + player.Sprint) / 5.0;
            }

            return totalPoints / players.Count;
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!players.Any(x => x.Name == playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {this.name} team.");
            }

            Player playerToRemove = players.Where(p => p.Name == playerName).First();
            players.Remove(playerToRemove);
        }
    }
}
