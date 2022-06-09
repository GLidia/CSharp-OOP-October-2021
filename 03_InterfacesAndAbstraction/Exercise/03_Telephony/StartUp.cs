using System;

namespace _03_Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            foreach (string number in numbers)
            {
                bool isValid = true;
                foreach (char symbol in number)
                {
                    if (!char.IsDigit(symbol))
                    {
                        isValid = false;
                    }
                }

                if (isValid && number.Length == 7)
                {
                    stationaryPhone.Call(number);
                }
                else if (isValid && number.Length == 10)
                {
                    smartphone.Call(number);
                }
                else if (!isValid)
                {
                    Console.WriteLine("Invalid number!");
                }

            }

            foreach (string url in urls)
            {
                bool isValid = true;
                foreach (char symbol in url)
                {
                    if (char.IsDigit(symbol))
                    {
                        isValid = false;
                    }
                }

                if (!isValid)
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    smartphone.Browse(url);
                }
            }
        }
    }
}
