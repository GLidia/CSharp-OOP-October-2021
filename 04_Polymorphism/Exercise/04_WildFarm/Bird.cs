using System;
using System.Collections.Generic;
using System.Text;

namespace _04_WildFarm
{
    public abstract class Bird : Animal
    {
        public double WingSize { get; protected set; }

        public Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            this.WingSize = wingSize;
        }
    }
}
