using System;
using System.Collections.Generic;
using System.Text;

namespace _07_MilitaryElite
{
    public class Privat : Soldier, IPrivat
    {
        public decimal Salary { get; private set; }

        public Privat(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";
        }
    }
}
