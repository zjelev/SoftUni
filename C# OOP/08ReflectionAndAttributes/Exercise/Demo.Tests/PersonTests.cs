using NUnit.Framework;
using System;

namespace Demo.Tests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void Test1()
        {
            Person person = new Person("Peter");
            Assert.AreEqual("Peter", person.Name);
        }

        [Test]
        public void Test2()
        {
            Assert.Throws<ArgumentException>(() => new Person(""));
        }
    }
}