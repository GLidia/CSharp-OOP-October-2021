using System;

namespace _09_ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split();
                Citizen citizen = new Citizen(info[0], info[1], int.Parse(info[2]));
                IPerson iperson = citizen;
                IResident iresident = citizen;
                Console.WriteLine(iperson.GetName());
                Console.WriteLine(iresident.GetName());
            }
        }
    }
}
