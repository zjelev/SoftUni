using System;
using System.Collections.Generic;
using MilitaryElite.Interfaces;
using MilitaryElite.Models;
using System.Linq;

namespace MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {           
            ISoldier soldier = null;

            ICollection<ISoldier> soldiers = new List<ISoldier>();
            
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] token = input.Split();

                switch (token[0])
                {
                    case "Private":
                        soldier = new Private(int.Parse(token[1]), token[2], token[3], decimal.Parse(token[4]));
                        soldiers.Add(soldier);
                        break;
                    
                    case "LieutenantGeneral":
                        LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(int.Parse(token[1]), token[2], token[3], decimal.Parse(token[4]));
                        for (int i = 5; i < token.Length; i++)                        
                        {
                            if (soldiers.FirstOrDefault(s => s.Id == int.Parse(token[i])) is IPrivate @private)
                            {
                                lieutenantGeneral.AddPrivate(@private);
                            }
                        }
                        soldier = lieutenantGeneral as ILieutenantGeneral;
                        soldiers.Add(soldier);
                        break;
                    
                    case "Engineer":
                        IEngineer engineer;
                        try
                        {
                            engineer = new Engineer(int.Parse(token[1]), token[2], token[3], decimal.Parse(token[4]), token[5]);
                            soldier = engineer as IEngineer;
                            for (int i = 6; i < token.Length-1; i+=2)
                            {
                                IRepair repair = new Repair(token[i], int.Parse(token[i+1])) as IRepair;
                                engineer.AddRepair(repair);
                            }
                            soldiers.Add(soldier);
                        }
                        catch (ArgumentException)
                        {
                            //Console.WriteLine(e.Message);
                            //throw;
                        }
                        break;                  
                    
                    case "Commando":
                        try
                        {
                            ICommando commando = new Commando(int.Parse(token[1]), token[2], token[3], decimal.Parse(token[4]), token[5]);
                            soldier = commando as ISoldier;
                            for (int i = 6; i < token.Length - 1; i+=2)
                            {
                                IMission mission = new Mission(token[i], token[i+1]) as IMission;
                                if (mission.State == "inProgress" || mission.State == "Finished")
                                {
                                    commando.AddMission(mission);
                                }
                            }
                            soldiers.Add(soldier);                            
                        }
                        catch (System.ArgumentException)
                        {
                            
                            //throw;
                        }

                        break;

                    case "Spy":
                        ISpy spy = new Spy(int.Parse(token[1]), token[2], token[3], int.Parse(token[4].ToLower()));
                        soldier = spy as ISoldier;
                        soldiers.Add(soldier);
                        break;
                    
                    default:
                        break;
                }
                input = Console.ReadLine();
            }

            foreach (var @item in soldiers)
            {
                Console.WriteLine(@item);
            }
        }
    }
}
