using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        Database.Database database;

        [SetUp]
        public void Setup()
        {
            //Arange
            database = new Database.Database(0, 1);
        }

        [Test]
        public void Ctor_EmptyCollection_ReturnZero()
        {
            //Arange
            database = new Database.Database();

            //Act
            int actualRes = database.Count;
            int expectedRes = 0;

            //Assert
            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        public void Ctor_TwoInt_ReturnCountTwo()
        {
            //Arange
            int expectedRes = 2;

            //Act
            int actualRes = database.Count;

            //Assert
            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        public void Ctor_TwoInt_AddedCorrectly()
        {
            //Arange
            int[] expectedRes = { 0, 1 };

            //Act
            int[] actualRes = database.Fetch();

            //Assert
            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        public void Ctor_Add17int_ThrowException()
        {
            //Arange
            int[] numbers = new int[17];

            //Assert
            Assert.Throws<InvalidOperationException>(() => new Database.Database(numbers));
        }

        [Test]
        public void AddMoreThan16Numbers_ThrowsException()
        {
            //Arange
            int[] numbers = new int[16];
            database = new Database.Database(numbers);
            
            //Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(3), "Oh well, whatever, nevermind");
        }

        [Test]
        public void Add_IncrementCounter()
        {
            //Arange
            int expectedRes = 5;

            //Act
            database.Add(0);
            database.Add(1);
            database.Add(2);
            int actualRes = database.Count;

            //Assert
            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        public void Add_Correctly()
        {
            //Arange
            int[] expectedRes = { 0, 1, 2, 3, 4 };

            //Act
            database.Add(2);
            database.Add(3);
            database.Add(4);
            int[] actualRes = database.Fetch();

            //Assert
            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        public void Remove_Correctly()
        {
            //Arange
            int expectedRes = 1;

            //Act
            database.Remove();

            int actualRes = database.Count;

            //Assert
            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        public void RemoveFromEmptyDB_ThrowsException()
        {
            //Arange
            database = new Database.Database();

            //Assert
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
    }
}