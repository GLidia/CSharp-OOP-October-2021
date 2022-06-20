using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
            this.Power = 100;
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
