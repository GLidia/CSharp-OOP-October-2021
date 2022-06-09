using System;
using System.Collections.Generic;
using System.Text;

namespace _07_MilitaryElite
{
    public class LieutenantGeneral : Privat, ILieutenantGeneral
    {
        public HashSet<Privat> Privates { get; private set; }

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            this.Privates = new HashSet<Privat>();
        }

        public void AddPrivat(Privat privat)
        {
            this.Privates.Add(privat);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}\nPrivates:");
            foreach (Privat privat in this.Privates)
            {
                sb.Append("\n  " + privat.ToString());
            }

            return sb.ToString();
        }
    }
}
