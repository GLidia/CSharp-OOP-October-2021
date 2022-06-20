using System;
using System.Collections.Generic;
using System.Text;

namespace _04_WildFarm
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; protected set; }

        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }
    }
}
