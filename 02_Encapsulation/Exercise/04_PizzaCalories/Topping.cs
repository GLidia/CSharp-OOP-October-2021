using System;
using System.Collections.Generic;
using System.Text;

namespace _04_PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;

        public string Type
        {
            get { return this.type; }
            private set 
            { 
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "sauce" && value.ToLower() !="cheese")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value; 
            }
        }

        public double Weight
        {
            get { return this.weight; }
            private set 
            { 
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public double CaloriesPerGram
        {
            get { return this.CalculateCaloriesPerGram(); }

        }

        private double CalculateCaloriesPerGram()
        {
            double typeModifier = 0;
            switch (this.type.ToLower())
            {
                case "meat":
                    typeModifier = 1.2;
                    break;
                case "veggies":
                    typeModifier = 0.8;
                    break;
                case "cheese":
                    typeModifier = 1.1;
                    break;
                case "sauce":
                    typeModifier = 0.9;
                    break;
            }

            return typeModifier * 2;
        }
    }
}
