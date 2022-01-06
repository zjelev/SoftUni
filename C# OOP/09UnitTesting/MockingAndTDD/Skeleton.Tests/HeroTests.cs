using Moq;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    [Test]
    public void GainsXPWhenTargetDies()
    {
        //Arrange
        Mock<IWeapon> mockedWeapon = new Mock<IWeapon>();
        //mockedWeapon.Setup(w => w.AttackPoints).Returns(10);
        //mockedWeapon.Setup(w => w.DurabilityPoints).Returns(10);
        Mock<ITarget> mockedTarget = new Mock<ITarget>();
        //mockedTarget.Setup(t => t.Health).Returns(0);
        mockedTarget.Setup(t => t.IsDead()).Returns(true);
        mockedTarget.Setup(t => t.GiveExperience()).Returns(10);
        IWeapon weapon = mockedWeapon.Object;
        ITarget target = mockedTarget.Object;
        Hero hero = new Hero("Pesho", weapon);

        //Act
        hero.Attack(target);

        Assert.That(hero.Experience, Is.EqualTo(10), "Hero does not gain XP when target dies");
    }
}