using System;
using CarManager;
using NUnit.Framework;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(null)]
        [TestCase("1")]
        public void MakeNullEmpltyThrowsExc(string make)
            {
                Assert.Throws<ArgumentException>(()
                    => new Car(make, "model", 0, 0));
            }
    }
}