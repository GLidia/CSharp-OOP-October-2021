using System;
using System.Collections.Generic;
using System.Text;

namespace _07_MilitaryElite
{
    public class Mission
    {
        private string state;
        public string CodeName { get; private set; }
        public string State
        {
            get { return this.state; }
            private set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    throw new ArgumentException("Invalid state");
                }
                this.state = value;
            }
        }

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public void CompleteMission()
        {
            this.state = "Finished";
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.state}";
        }
    }
}
