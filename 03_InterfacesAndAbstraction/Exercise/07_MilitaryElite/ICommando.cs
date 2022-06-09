using System;
using System.Collections.Generic;
using System.Text;

namespace _07_MilitaryElite
{
    public interface ICommando : ISpecializedSoldier
    {
        HashSet<Mission> Missions { get; }
    }
}
