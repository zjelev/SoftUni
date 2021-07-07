namespace Raiding.Factories
{
    using Raiding.Model;
    public interface IHeroFactory
    {
        IHero MakeHero(string type, string name);
    }
}