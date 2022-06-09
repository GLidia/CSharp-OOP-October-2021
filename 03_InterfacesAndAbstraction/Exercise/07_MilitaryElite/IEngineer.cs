using System;
using System.Collections.Generic;
using System.Text;

namespace _07_MilitaryElite
{
    public interface IEngineer : ISpecializedSoldier
    {
        HashSet<Repair> Repairs { get; }
    }
}
