using NUnit.Framework;
using ExtendedDatabase;
using System;

namespace Tests
{
    [TestFixture]
    public class ExtendedDatabaseTests
    {
        ExtendedDatabase.ExtendedDatabase db;
        
        [SetUp]
        public void Setup()
        {
            Person[] persons = new Person[15];

            for (long i = 0; i < 15; i++)
            {
                Person person = new Person(i+1, $"Pesho {i+1}");
                persons[i] = person;
            }

            db = new ExtendedDatabase.ExtendedDatabase(persons);
        }

        [Test]
        public void AddExistingPersonThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(16, "Pesho1")));
        }

        [Test]
        public void AddExistingIdThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(15, "Pesho")));
        }

        [Test]
        public void RemoveFromEmptyDBThrowsException()
        {
            db = new ExtendedDatabase.ExtendedDatabase();
            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }
        
        [Test]
        public void FindByNonexistingUsernameThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => db.FindByUsername("Pesho500"));
        }

        [Test]
        public void FindByUsernameEmptyThrowsExc()
        {
            Assert.Throws<ArgumentNullException>(() => db.FindByUsername(""));
        }

        [Test]
        public void FindByUsernameCaseSensitiveThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => db.FindByUsername("pesho 1"));
        }

        [Test]
        public void FindByIdNonExistThrowsExc()
        {
            Assert.Throws<InvalidOperationException>(() => db.FindById(0));
        }

        [Test]
        public void FindByIdNegativeThrowsExc()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => db.FindById(-1));
        }
    }
}