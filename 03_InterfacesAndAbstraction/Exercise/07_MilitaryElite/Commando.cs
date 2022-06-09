using System;
using System.Collections.Generic;
using System.Text;

namespace _07_MilitaryElite
{
    public class Commando : SpecializedSoldier, ICommando
    {
        public HashSet<Mission> Missions { get; private set; }

        public Commando(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new HashSet<Mission>();
        }

        public void AddMission(Mission mission)
        {
            this.Missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}\nCorps: {this.Corps}\nMissions:");
            foreach (Mission mission in this.Missions)
            {

                    sb.Append("\n  " + mission.ToString());


            }
            return sb.ToString();
        }
    }
}
