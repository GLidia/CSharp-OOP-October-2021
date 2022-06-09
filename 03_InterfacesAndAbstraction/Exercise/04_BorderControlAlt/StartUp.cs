using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_BorderControlAlt
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IIdentifiable> everybody = new List<IIdentifiable>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split();

                if (data.Length == 2)
                {
                    Robot robot = new Robot(data[0], data[1]);
                    everybody.Add(robot);
                }
                else if (data.Length == 3)
                {
                    Citizen citizen = new Citizen(data[0], int.Parse(data[1]), data[2]);
                    everybody.Add(citizen);
                }
            }

            string lastDigits = Console.ReadLine();

            foreach (IIdentifiable item in everybody)
            {
                if (item.Id.EndsWith(lastDigits))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}
