using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ShoppingSpree
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> allProducts = new List<Product>();

            try
            {
                
                string[] personsInfo = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in personsInfo)
                {
                    string[] nameAndMoney = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = nameAndMoney[0];
                    decimal money = decimal.Parse(nameAndMoney[1]);
                    Person person = new Person(name, money);
                    people.Add(person);
                }

                
                string[] productsInfo = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in productsInfo)
                {
                    string[] nameAndCost = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = nameAndCost[0];
                    decimal cost = decimal.Parse(nameAndCost[1]);

                    Product product = new Product(name, cost);
                    allProducts.Add(product);

                }
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split();
                string personName = command[0];
                string productName = command[1];

                Person person = people.Where(p => p.Name == personName).FirstOrDefault();
                Product product = allProducts.Where(p => p.Name == productName).FirstOrDefault();

                person.Buy(product);
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
