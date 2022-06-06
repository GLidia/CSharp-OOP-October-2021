using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        public double DefaultCakeGrams = 250;
        public double DefaultCakeCalories = 1000;
        public decimal DefaultCakePrice = 5;
        
        public Cake(string name) : base(name, 0, 0, 0) { }

        public override decimal Price { get => this.DefaultCakePrice; }
        public override double Calories { get => this.DefaultCakeCalories; }
        public override double Grams { get => this.DefaultCakeGrams;}
    }
}
