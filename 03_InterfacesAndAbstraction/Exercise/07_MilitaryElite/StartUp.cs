using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_MilitaryElite
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input;
            List<Privat> privates = new List<Privat>();
            List<ISoldier> all = new List<ISoldier>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split();
                string type = data[0];

                switch (type)
                {
                    case "Private":
                        Privat privat = new Privat(data[1], data[2], data[3], decimal.Parse(data[4]));
                        privates.Add(privat);
                        all.Add(privat);
                        break;
                    case "LieutenantGeneral":
                        LieutenantGeneral lieutenant = new LieutenantGeneral(data[1], data[2], data[3], decimal.Parse(data[4]));
                        for (int i = 5; i < data.Length; i++)
                        {
                            string id = data[i];
                            Privat privatToAdd = privates.Where(x => x.Id == id).FirstOrDefault();
                            lieutenant.AddPrivat(privatToAdd);
                        }
                        all.Add(lieutenant);
                        break;
                    case "Engineer":
                        try
                        {
                            Engineer engineer = new Engineer(data[1], data[2], data[3], decimal.Parse(data[4]), data[5]);
                            for (int i = 6; i < data.Length; i += 2)
                            {
                                Repair repair = new Repair(data[i], int.Parse(data[i + 1]));
                                engineer.AddRepair(repair);
                            }
                            all.Add(engineer);
                        }
                        catch
                        {

                        }
                        break;
                    case "Commando":
                        try
                        {
                            Commando commando = new Commando(data[1], data[2], data[3], decimal.Parse(data[4]), data[5]);
                            for (int i = 6; i < data.Length; i += 2)
                            {
                                try
                                {
                                    Mission mission = new Mission(data[i], data[i + 1]);
                                    commando.AddMission(mission);
                                }
                                catch { }
                            }
                            all.Add(commando);
                        }
                        catch { }
                        break;
                    case "Spy":
                        Spy spy = new Spy(data[1], data[2], data[3], int.Parse(data[4]));
                        all.Add(spy);
                        break;

                }
            }

            foreach (ISoldier soldier in all)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
