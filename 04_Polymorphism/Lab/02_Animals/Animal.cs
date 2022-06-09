using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private string favoriteFood;

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }

        public string FavoriteFood
        {
            get { return this.favoriteFood; }
            protected set { this.favoriteFood = value; }
        }

        protected Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favoriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.name} and my favorite food is {this.favoriteFood}";
        }
    }
}
