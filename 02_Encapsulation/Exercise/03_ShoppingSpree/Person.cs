using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == null || value == string.Empty || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public List<Product> Products {
            get { return this.products; }
            private set
            {
                this.products = value;
            }
        }

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }

        public void Buy(Product product)
        {
            if (this.money >= product.Cost)
            {
                this.money -= product.Cost;
                this.products.Add(product);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            if (this.products.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            else
            {
                string toReturn = $"{this.Name} - ";
                int count = 0;
                foreach (Product product in this.products)
                {
                    count++;
                    if (count == this.products.Count)
                    {
                        toReturn += $"{product.Name}";
                    }
                    else
                    {
                        toReturn += $"{product.Name}, ";
                    }

                }
                return toReturn;
            }
        }
    }
}
