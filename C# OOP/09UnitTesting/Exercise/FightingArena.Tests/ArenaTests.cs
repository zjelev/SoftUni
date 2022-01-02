using System;
using System.Linq;
using FightingArena;
using NUnit.Framework;

namespace Tests
{
    public class ArenaTests
    {
        Arena arena;
        [SetUp]
        public void Setup()
        {
            arena = new Arena();

            for (int i = 1; i < 4; i++)
            {
                Warrior warrior = new Warrior($"Warrior {i}", i * 10, i * 40);
                arena.Enroll(warrior);
            }
        }

        [Test]
        public void EnrollExistingNameThrowsExc()
        {
            Assert.Throws<InvalidOperationException>(()
                => arena.Enroll(new Warrior("Warrior 2", 50, 100)));
        }

        [Test]
        public void MissingWarriorsThrowExc()
        {
            Assert.Throws<InvalidOperationException>(()
                => arena.Fight("Warrior 1", "Warrior 5"));
            
            Assert.Throws<InvalidOperationException>(()
                => arena.Fight("Warrior 6", "Warrior 2"));
        }

        [Test]
        public void ExistingWarriorsFight()
        {
            arena.Fight("Warrior 3", "Warrior 1");
            Assert.AreEqual(10, arena.Warriors.FirstOrDefault(w
                => w.Name == "Warrior 1").HP);
        }
    }
}
