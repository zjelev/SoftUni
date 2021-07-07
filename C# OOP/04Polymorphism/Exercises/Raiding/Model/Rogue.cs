namespace Raiding.Model
{
    public class Rogue : BaseHero
    {
        private const int POWER = 80;

        public Rogue(string name) : base(name)
        {
        }

        public override int Power => POWER;

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {Power} damage";
        }
    }
}
