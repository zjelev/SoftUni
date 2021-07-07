namespace Raiding.Model
{
    public class Druid : BaseHero
    {
        private const int POWER = 80;

        public Druid(string name) : base(name)
        {
        }

        public override int Power => POWER;
    }
}
