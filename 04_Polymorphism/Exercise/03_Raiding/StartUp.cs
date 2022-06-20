using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Raiding
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            int N = int.Parse(Console.ReadLine());

            while (heroes.Count < N)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                if (type == "Druid")
                {
                    BaseHero druid = new Druid(name);
                    heroes.Add(druid);
                }
                else if (type == "Paladin")
                {
                    BaseHero paladin = new Paladin(name);
                    heroes.Add(paladin);
                }
                else if (type == "Rogue")
                {
                    BaseHero rogue = new Rogue(name);
                    heroes.Add(rogue);
                }
                else if (type == "Warrior")
                {
                    BaseHero warrior = new Warrior(name);
                    heroes.Add(warrior);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }

            }

            int bossPower = int.Parse(Console.ReadLine());
            int totalPowerOfHeroes = heroes.Select(hero => hero.Power).Sum();

            foreach (BaseHero hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            if (totalPowerOfHeroes >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
