using System;
using System.Collections.Generic;
using System.Text;

namespace _07_MilitaryElite
{
    public class SpecializedSoldier : Privat, ISpecializedSoldier
    {
        private string corps;
        public string Corps
        {
            get { return this.corps; }
            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException("Invalid corps");
                }
                this.corps = value;
            }
        }

        public SpecializedSoldier(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }
    }
}
