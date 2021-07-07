using Raiding.Model;

namespace Raiding.Factories
{
    public class HeroFactory : IHeroFactory
    {
        private IHero hero = null;
        public IHero MakeHero(string type, string name)
        {            
            if (type == nameof(Druid))
            {
                hero = new Druid(name);
            }
            else if (type == nameof(Paladin))
            {
                hero = new Paladin(name);
            }
            else if (type == nameof(Rogue))
            {
                hero = new Rogue(name);
            }
            else if (type == nameof(Warrior))
            {
                hero = new Warrior(name);
            }
            else
            {
                throw new System.ArgumentException("Invalid hero!");
            }

            return hero;
        }
    }
}
