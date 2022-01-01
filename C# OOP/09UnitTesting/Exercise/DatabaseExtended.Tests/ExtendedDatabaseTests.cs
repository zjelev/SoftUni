using NUnit.Framework;
using ExtendedDatabase;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        ExtendedDatabase.Database db;
        
        [SetUp]
        public void Setup()
        {
            Person[] persons = new Person[15];

            for (long i = 0; i < 15; i++)
            {
                Person person = new Person(i+1, $"Existing {i+1}");
                persons[i] = person;
            }

            db = new ExtendedDatabase.Database(persons);
        }

        [TestCase(2)]
        public void CtorAddsPeopleCorrectly(int num)
        {
            db = new ExtendedDatabase.Database();
            Person[] people = new Person[num];
            for (int i = 0; i < num; i++)
            {
                Person person = new Person(i+1, $"Existing {i+1}");
                people[i] = person;
            }

            db = new ExtendedDatabase.Database(people);

            Assert.AreEqual(num, db.Count);
        }

        [TestCase(17)]
        public void CtorAddsMoreThan16ThrowsExc(int num)
        {
            db = new ExtendedDatabase.Database();
            Person[] people = new Person[num];
            for (int i = 0; i < num; i++)
            {
                Person person = new Person(i + 1, $"Existing {i + 1}");
                people[i] = person;
            }

            Assert.Throws<ArgumentException>(() => new ExtendedDatabase.Database(people));
        }

        [TestCase("A")]
        public void CtorAddExistingPersonNameThrowsExc(string name)
        {
            Person personOne = new Person(1, name);
            Person personTwo = new Person(2, name);

            Assert.Throws<InvalidOperationException>(() 
                => new ExtendedDatabase.Database(personOne, personTwo));
        }

        [TestCase(1)]
        public void CtorAddExistingPersonIDThrowsExc(long id)
        {
            Person personOne = new Person(id, "A");
            Person personTwo = new Person(id, "B");

            Assert.Throws<InvalidOperationException>(() 
                => new ExtendedDatabase.Database(personOne, personTwo));
        }

        [TestCase(16)]
        public void AddCorrectly(long id)
        {
            db.Add(new Person(id, "New"));

            Assert.AreEqual(id, db.Count);
        }

        [TestCase(17, "Existing 1")]
        [TestCase(15, "NonExisting")]
        public void AddExistingPersonOrIdThrowsException(long id, string name)
        {
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(id, name)));
        }

        [TestCase(16, "Existing")]
        public void AddAboveCountThrowsException(long id, string name)
        {
            db.Add(new Person(id, $"{name} {id}"));
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(id + 1, $"{name} {id + 1}")));
        }

        [Test]
        public void RemoveFromEmptyDBThrowsException()
        {
            db = new ExtendedDatabase.Database();
            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }

        [Test]
        public void RemoveOneDecrementsCount()
        {
            db.Remove();
            Assert.AreEqual(14, db.Count);
        }

        [TestCase("NonExisting")]
        [TestCase("existing 1")]
        public void FindByNonexistingUsernameThrowsException(string name)
        {
            Assert.Throws<InvalidOperationException>(() => db.FindByUsername(name));
        }

        [TestCase("")]
        [TestCase(null)]
        public void FindByUsernameEmptyThrowsExc(string name)
        {
            Assert.Throws<ArgumentNullException>(() => db.FindByUsername(name));
        }

        [TestCase(0)]
        [TestCase(20)]
        public void FindByIdNonExistThrowsExc(long id)
        {
            Assert.Throws<InvalidOperationException>(() => db.FindById(id));
        }
        
        [Test]
        public void FindByIdNegativeThrowsExc()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => db.FindById(-1));
        }

        [TestCase(1, "Existing 1")]
        public void FindReturnsExisting(long id, string name)
        {
            Assert.AreEqual(id, db.FindById(id).Id);
            Assert.AreEqual(name, db.FindById(id).UserName);
        }
    }
}