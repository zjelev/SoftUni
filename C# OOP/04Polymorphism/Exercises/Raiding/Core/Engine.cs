using System;

namespace Raiding.Core
{
    using Raiding.Model;
    using Raiding.Factories;
    using System.Collections.Generic;

    public class Engine : IEngine
    {
        public void Run()
        {
            IHeroFactory heroFactory = new HeroFactory();
            IHero hero = null;
            List<IHero> heroes = new List<IHero>();
            int raidPower = 0;

            int n = int.Parse(Console.ReadLine());
                        
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    hero = heroFactory.MakeHero(type, name);
                    heroes.Add(hero);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var her in heroes)
            {
                Console.WriteLine(her.CastAbility());
                raidPower += her.Power;
            }

            if (raidPower >= bossPower)
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
