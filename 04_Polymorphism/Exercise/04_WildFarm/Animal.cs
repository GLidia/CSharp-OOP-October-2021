using System;
using System.Collections.Generic;
using System.Text;

namespace _04_WildFarm
{
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public abstract void Eat(Food food);
        public abstract string AskForFood();
    }
}
