using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private Dummy target;
    private const int attackPoints = 10;
    private const int health = 20;
    private const int xp = 20;

    [SetUp]
    public void Initialize()
    {
        target = new Dummy(health, xp);
    }

    [Test]
    public void LosesHealthIfAttacked()
    {
        target.TakeAttack(attackPoints);

        Assert.That(target.Health, Is.EqualTo(10), "Dummy does not lose health on attack");
    }

    [Test]
    public void DeadDummyAttacked()
    {
        target.TakeAttack(20);

        Assert.That(() => target.TakeAttack(attackPoints),
            Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."), 
            "Dead dummy can be attacked");
    }

    [Test]
    public void CanGiveXP()
    {
        target.TakeAttack(attackPoints * 2);
        Assert.That(target.GiveExperience(), Is.EqualTo(20));
    }

    [Test]
    public void CanNotGiveXP()
    {
         Assert.That(() => target.GiveExperience(),
            Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
}
