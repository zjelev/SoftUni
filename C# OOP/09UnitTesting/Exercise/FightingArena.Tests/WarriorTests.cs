using System;
using FightingArena;
using NUnit.Framework;

namespace Tests
{
    public class WarriorTests
    {
        Warrior warrior;
        [SetUp]
        public void Setup()
        {
            warrior = new Warrior("name", 10, 20);
        }

        [TestCase(null)]
        [TestCase("  ")]
        [TestCase("")]
        public void CtorNameNullOrWhiteSpaceThrowsExc(string name)
        {
            Assert.Throws<ArgumentException>(()
                => new Warrior(name, 10, 20));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void CtorDamageZeroOrNegativeThrowsExc(int damage)
        {
            Assert.Throws<ArgumentException>(()
                => new Warrior("name", damage, 20));
        }

        [TestCase(-1)]
        public void CtorHPNegativeThrowsExc(int hp)
        {
            Assert.Throws<ArgumentException>(()
                => new Warrior("name", 10, hp));
        }

        [TestCase(40)]
        public void AttackBelowMinAttackHPThrowExc(int hp)
        {
            Assert.Throws<InvalidOperationException>(()
                => warrior.Attack(new Warrior("name", 10, hp)));

            warrior = new Warrior("name", 10, hp);

            Assert.Throws<InvalidOperationException>(()
                => warrior.Attack(new Warrior("name", 10, 20)));

            Assert.Throws<InvalidOperationException>(()
                => warrior.Attack(new Warrior("name", 50, 50)));
        }

        [TestCase(40)]
        public void AttackReducesTargetsHPWithAttackersDamage(int damage)
        {
            warrior = new Warrior("name", damage, 100);
            Warrior target = new Warrior("target", 5, 75);
            warrior.Attack(target);
            Assert.AreEqual(35, target.HP);
            warrior.Attack(target);
            Assert.AreEqual(0, target.HP);
        }
    }
}