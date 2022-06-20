using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Raiding
{
    public abstract class BaseHero
    {
        public string Name { get; protected set; }
        public int Power { get; protected set; }

        public BaseHero(string name)
        {
            this.Name = name;
        }
        public abstract string CastAbility();
    }
}
