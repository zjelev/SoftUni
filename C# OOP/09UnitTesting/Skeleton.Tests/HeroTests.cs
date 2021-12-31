using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    [Test]
    public void GainsXPWhenTargetDies()
    {
        Hero hero = new Hero("Pesho", new FakeWeapon());
        hero.Attack(new FakeTarget());
        Assert.That(hero.Experience, Is.EqualTo(10), "Hero does not gain XP when target dies");
    }
}