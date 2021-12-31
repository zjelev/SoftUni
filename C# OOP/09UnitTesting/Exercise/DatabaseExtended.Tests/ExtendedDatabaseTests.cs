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
                Person person = new Person(i + 1, "Pesho"+i.ToString());
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
        
        public void FindByNonexistingUsernameThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => db.FindByUsername("Pesho500"));
        }
    }
}