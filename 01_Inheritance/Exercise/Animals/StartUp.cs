using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string input = Console.ReadLine();

            while (input != "Beast!")
            {
                string animalType = input;
                string[] info = Console.ReadLine().Split();

                switch (animalType)
                {
                    case "Tomcat":
                        try
                        {
                            if (info.Length == 3)
                            {
                                Tomcat tomcat = new Tomcat(info[0], int.Parse(info[1]), info[2]);
                                animals.Add(tomcat);
                            }
                            else if (info.Length == 2)
                            {
                                Tomcat tomcat1 = new Tomcat(info[0], int.Parse(info[1]));
                                animals.Add(tomcat1);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    case "Kitten":
                        try
                        {
                            if (info.Length == 3)
                            {
                                Kitten kitten = new Kitten(info[0], int.Parse(info[1]), info[2]);
                                animals.Add(kitten);
                            }
                            else if (info.Length == 2)
                            {
                                Kitten kitten1 = new Kitten(info[0], int.Parse(info[1]));
                                animals.Add(kitten1);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    case "Cat":
                        try
                        {
                            Cat cat = new Cat(info[0], int.Parse(info[1]), info[2]);
                            animals.Add(cat);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    case "Frog":
                        try
                        {
                            Frog frog = new Frog(info[0], int.Parse(info[1]), info[2]);
                            animals.Add(frog);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    case "Dog":
                        try
                        {
                            Dog dog = new Dog(info[0], int.Parse(info[1]), info[2]);
                            animals.Add(dog);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
