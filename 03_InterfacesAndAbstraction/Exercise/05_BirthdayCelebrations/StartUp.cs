using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_BirthdayCelebrations
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBirthable> birthables = new List<IBirthable>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split();
                string type = data[0];

                if (type == "Robot")
                {
                    continue;
                }
                else if (type == "Citizen")
                {
                    Citizen citizen = new Citizen(data[1], int.Parse(data[2]), data[3], data[4].Trim());
                    birthables.Add(citizen);
                }
                else if (type == "Pet")
                {
                    Pet pet = new Pet(data[1], data[2]);
                    birthables.Add(pet);
                }
            }

            string year = Console.ReadLine();

            foreach (IBirthable item in birthables.Where(b => b.Birthdate.EndsWith(year)))
            {
                Console.WriteLine(item.Birthdate);
            }
        }
    }
}
