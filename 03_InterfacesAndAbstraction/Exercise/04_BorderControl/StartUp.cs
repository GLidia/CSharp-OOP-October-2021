using System;
using System.Collections.Generic;

namespace _04_BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input;
            List<string> ids = new List<string>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split();

                if (data.Length == 2)
                {
                    ids.Add(data[1]);
                }
                else if (data.Length == 3)
                {
                    ids.Add(data[2]);
                }
            }

            string lastDigits = Console.ReadLine();

            foreach (string id in ids)
            {
                if (id.EndsWith(lastDigits))
                {
                    Console.WriteLine(id);
                }
            }
        }
    }
}
