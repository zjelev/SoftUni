namespace Raiding.Model
{
    public class Paladin : BaseHero
    {
        private const int POWER = 100;

        public Paladin(string name) : base(name)
        {
        }

        public override int Power => POWER;
    }
}
