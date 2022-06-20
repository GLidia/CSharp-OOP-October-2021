using System;
using System.Collections.Generic;
using System.Text;

namespace _04_WildFarm
{
    public abstract class Feline : Mammal
    {
        public string Breed { get; protected set; }

        public Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }
    }
}
