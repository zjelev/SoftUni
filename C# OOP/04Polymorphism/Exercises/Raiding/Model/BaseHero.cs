namespace Raiding.Model
{
    public abstract class BaseHero : IHero
    {
        protected BaseHero(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public virtual int Power { get; }

        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}