using System;
using System.Collections.Generic;

namespace _04_WildFarm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split();
                string type = data[0];

                string[] foodInfo = Console.ReadLine().Split();
                string foodType = foodInfo[0];
                int foodQuantity = int.Parse(foodInfo[1]);

                switch (type)
                {
                    case "Cat":
                        Animal cat = new Cat(data[1], double.Parse(data[2]), data[3], data[4]);
                        Console.WriteLine(cat.AskForFood());
                        switch (foodType)
                        {
                            case "Meat":
                                Food meat = new Meat(foodQuantity);
                                cat.Eat(meat);
                                break;
                            case "Vegetable":
                                Food vegetable = new Vegetable(foodQuantity);
                                cat.Eat(vegetable);
                                break;
                            case "Fruit":
                                Food fruit = new Fruit(foodQuantity);
                                cat.Eat(fruit);
                                break;
                            case "Seeds":
                                Food seeds = new Seeds(foodQuantity);
                                cat.Eat(seeds);
                                break;
                        }
                        animals.Add(cat);
                        break;
                    case "Tiger":
                        Animal tiger = new Tiger(data[1], double.Parse(data[2]), data[3], data[4]);
                        Console.WriteLine(tiger.AskForFood());
                        switch (foodType)
                        {
                            case "Meat":
                                Food meat = new Meat(foodQuantity);
                                tiger.Eat(meat);
                                break;
                            case "Vegetable":
                                Food vegetable = new Vegetable(foodQuantity);
                                tiger.Eat(vegetable);
                                break;
                            case "Fruit":
                                Food fruit = new Fruit(foodQuantity);
                                tiger.Eat(fruit);
                                break;
                            case "Seeds":
                                Food seeds = new Seeds(foodQuantity);
                                tiger.Eat(seeds);
                                break;
                        }
                        animals.Add(tiger);
                        break;
                    case "Owl":
                        Animal owl = new Owl(data[1], double.Parse(data[2]), double.Parse(data[3]));
                        Console.WriteLine(owl.AskForFood());
                        switch (foodType)
                        {
                            case "Meat":
                                Food meat = new Meat(foodQuantity);
                                owl.Eat(meat);
                                break;
                            case "Vegetable":
                                Food vegetable = new Vegetable(foodQuantity);
                                owl.Eat(vegetable);
                                break;
                            case "Fruit":
                                Food fruit = new Fruit(foodQuantity);
                                owl.Eat(fruit);
                                break;
                            case "Seeds":
                                Food seeds = new Seeds(foodQuantity);
                                owl.Eat(seeds);
                                break;
                        }
                        animals.Add(owl);
                        break;
                    case "Hen":
                        Animal hen = new Hen(data[1], double.Parse(data[2]), double.Parse(data[3]));
                        Console.WriteLine(hen.AskForFood());
                        switch (foodType)
                        {
                            case "Meat":
                                Food meat = new Meat(foodQuantity);
                                hen.Eat(meat);
                                break;
                            case "Vegetable":
                                Food vegetable = new Vegetable(foodQuantity);
                                hen.Eat(vegetable);
                                break;
                            case "Fruit":
                                Food fruit = new Fruit(foodQuantity);
                                hen.Eat(fruit);
                                break;
                            case "Seeds":
                                Food seeds = new Seeds(foodQuantity);
                                hen.Eat(seeds);
                                break;
                        }
                        animals.Add(hen);
                        break;
                    case "Dog":
                        Animal dog = new Dog(data[1], double.Parse(data[2]), data[3]);
                        Console.WriteLine(dog.AskForFood());
                        switch (foodType)
                        {
                            case "Meat":
                                Food meat = new Meat(foodQuantity);
                                dog.Eat(meat);
                                break;
                            case "Vegetable":
                                Food vegetable = new Vegetable(foodQuantity);
                                dog.Eat(vegetable);
                                break;
                            case "Fruit":
                                Food fruit = new Fruit(foodQuantity);
                                dog.Eat(fruit);
                                break;
                            case "Seeds":
                                Food seeds = new Seeds(foodQuantity);
                                dog.Eat(seeds);
                                break;
                        }
                        animals.Add(dog);
                        break;
                    case "Mouse":
                        Animal mouse = new Mouse(data[1], double.Parse(data[2]), data[3]);
                        Console.WriteLine(mouse.AskForFood());
                        switch (foodType)
                        {
                            case "Meat":
                                Food meat = new Meat(foodQuantity);
                                mouse.Eat(meat);
                                break;
                            case "Vegetable":
                                Food vegetable = new Vegetable(foodQuantity);
                                mouse.Eat(vegetable);
                                break;
                            case "Fruit":
                                Food fruit = new Fruit(foodQuantity);
                                mouse.Eat(fruit);
                                break;
                            case "Seeds":
                                Food seeds = new Seeds(foodQuantity);
                                mouse.Eat(seeds);
                                break;
                        }
                        animals.Add(mouse);
                        break;
                }

            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
