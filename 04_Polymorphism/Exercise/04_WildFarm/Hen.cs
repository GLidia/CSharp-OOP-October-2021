using System;
using System.Collections.Generic;
using System.Text;

namespace _04_WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize) { }

        public override string AskForFood()
        {
            return "Cluck";
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.35;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
