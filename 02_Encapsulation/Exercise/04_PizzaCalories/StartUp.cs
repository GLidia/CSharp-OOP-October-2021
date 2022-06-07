using System;

namespace _04_PizzaCalories
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] pizzaInput = Console.ReadLine().Split();
                string pizzaName = pizzaInput[1];

                string[] input = Console.ReadLine().Split();
                string flourType = input[1];
                string bakingTechnique = input[2];
                double weight = double.Parse(input[3]);

                Dough dough = new Dough(flourType, bakingTechnique, weight);

                Pizza pizza = new Pizza(pizzaName, dough);

                string inputTopping;

                while ((inputTopping = Console.ReadLine()) != "END")
                {
                    string[] input2 = inputTopping.Split();
                    string toppingType = input2[1];
                    double toppingWeight = double.Parse(input2[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);
                    pizza.AddTopping(topping);
                }

                Console.WriteLine(pizza);
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }
        }
    }
}
