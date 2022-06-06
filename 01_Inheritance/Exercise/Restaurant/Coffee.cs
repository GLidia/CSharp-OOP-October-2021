using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public double CoffeeMilliliters = 50;
        public decimal CoffeePrice = 3.50M;
        public double Caffeine { get; set; }

        public Coffee(string name, double caffeine) : base(name, 0, 0)
        {
            this.Caffeine = caffeine;
        }

        public override decimal Price { get => this.CoffeePrice; }
        public override double Milliliters { get => this.CoffeeMilliliters; }
    }
}
