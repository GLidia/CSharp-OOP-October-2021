using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_FoodShortage
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();

            for (int i = 0; i < N; i++)
            {
                string[] data = Console.ReadLine().Split();

                if (data.Length == 4)
                {
                    Citizen citizen = new Citizen(data[0], int.Parse(data[1]), data[2], data[3]);
                    citizens.Add(citizen);
                }
                else if (data.Length == 3)
                {
                    Rebel rebel = new Rebel(data[0], int.Parse(data[1]), data[2]);
                    rebels.Add(rebel);
                }
            }

            int totalFoodBought = 0;

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string name = input;

                if (citizens.Any(c => c.Name == name))
                {
                    Citizen citizen = citizens.Where(c => c.Name == name).FirstOrDefault();
                    citizen.BuyFood();
                    totalFoodBought += 10;
                }
                else if (rebels.Any(rebels => rebels.Name == name))
                {
                    Rebel rebel = rebels.Where(r => r.Name == name).FirstOrDefault();
                    rebel.BuyFood();
                    totalFoodBought += 5;
                }
            }

            Console.WriteLine(totalFoodBought);
        }
    }
}
