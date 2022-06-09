using System;
using System.Collections.Generic;
using System.Text;

namespace _07_MilitaryElite
{
    public class Engineer : SpecializedSoldier, IEngineer
    {
        public HashSet<Repair> Repairs { get; private set; }

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new HashSet<Repair>();
        }

        public void AddRepair(Repair repair)
        {
            this.Repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}\nCorps: {this.Corps}\nRepairs:");

            foreach (Repair repair in this.Repairs)
            {

                    sb.Append("\n  " + repair.ToString());

            }
            return sb.ToString();
        }
    }
}
