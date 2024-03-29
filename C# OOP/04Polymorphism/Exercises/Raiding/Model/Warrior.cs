namespace Raiding.Model
{
    public class Warrior : BaseHero
    {
        private const int POWER = 100;

        public Warrior(string name) : base(name)
        {
        }

        public override int Power => POWER;

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {Power} damage";
        }
    }
}
