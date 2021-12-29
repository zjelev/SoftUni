using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private Dummy target;

    [SetUp]
    public void Setup()
    {
        this.target = new Dummy(5, 5);
    }

    [Test]
    public void DurabilityAfterAttack()
    {
        //Arrange
        Axe axe = new Axe(2, 2);

        //Act
        axe.Attack(target);

        //Assert
        Assert.That(axe.DurabilityPoints, Is.EqualTo(1), "Axe does notlose durability");
    }

    [Test]
    public void BrokenWeapon()
    {
        Axe axe = new Axe(2, 0);

        //Act & Assert
        Assert.That(() => axe.Attack(target),
            Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."), 
            "Broken weapon can attack");
    }
}