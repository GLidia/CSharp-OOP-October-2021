using System;
using System.Collections.Generic;
using System.Text;

namespace _04_PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public string Name
        {
            get { return this.name; }
            set
            { 
                if (value == null || value == string.Empty || value == " " || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public List<Topping> Toppings
        {
            get { return this.toppings; }
            set { this.toppings = value; }
        }

        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough = value; }
        }

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.Toppings = new List<Topping>();
        }

        public int ToppingCount
        {
            get { return this.Toppings.Count; }
        }

        public void AddTopping(Topping topping)
        {
            if (this.ToppingCount == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }

        public double TotalCalories
        {
            get 
            {
                double totalCalories = this.dough.CaloriesPerGram * this.dough.Weight;
                foreach (Topping topping in this.toppings)
                {
                    totalCalories += topping.CaloriesPerGram * topping.Weight;
                }
                return totalCalories;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TotalCalories:F2} Calories.";
        }
    }
}
