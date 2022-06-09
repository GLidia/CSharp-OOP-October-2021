using System;
using System.Collections.Generic;
using System.Text;

namespace _07_MilitaryElite
{
    public class Repair
    {
        public string PartName { get; private set; }
        public int Hours { get; private set; }

        public Repair(string partName, int hours)
        {
            this.PartName = partName;
            this.Hours = hours;
        }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.Hours}";
        }
    }
}
