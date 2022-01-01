using System;
using CarManager;
using NUnit.Framework;

namespace Tests
{
    public class CarTests
    {
        Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car("make", "model", 5, 60);
        }

        [TestCase(null)]
        [TestCase("")]
        public void CtorMakeNullEmptyThrowsExc(string make)
        {
            Assert.Throws<ArgumentException>(()
                => new Car(make, "model", 1, 1));
        }

        [TestCase(null)]
        [TestCase("")]
        public void CtorModelNullEmptyThrowsExc(string model)
        {
            Assert.Throws<ArgumentException>(()
                => new Car("make", model, 1, 1));
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void CtorFuelConsumptionNegativeThrowsExc(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(()
                => new Car("make", "model", fuelConsumption, 1));
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void CtorFuelCapacityNegativeThrowsExc(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(()
                => new Car("make", "model", 1, fuelCapacity));
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void RefuelNegativeThrowsExc(double fuelToRefuel)
        {
            Assert.Throws<ArgumentException>(()
                => car.Refuel(fuelToRefuel));
        }

        [TestCase(10)]
        public void DriveNotEnoughFuelThrowsExc(double fuelToRefuel)
        {
            car.Refuel(fuelToRefuel);
            Assert.Throws<InvalidOperationException>(()
                => car.Drive(300));
        }

        [TestCase(20)]
        public void RefuelCorrectly(double fuelToRefuel)
        {
            car.Refuel(fuelToRefuel);
            Assert.AreEqual(20, car.FuelAmount);
            car.Refuel(fuelToRefuel);
            Assert.AreEqual(40, car.FuelAmount);
            car.Refuel(fuelToRefuel);
            Assert.AreEqual(60, car.FuelAmount);
            car.Refuel(fuelToRefuel);
            Assert.AreEqual(60, car.FuelAmount);
        }

        [TestCase(200)]
        public void DriveReducesFuelCorrectly(double distance)
        {
            car.Refuel(40);
            car.Drive(distance);
            Assert.AreEqual(30, car.FuelAmount);
            car.Drive(distance);
            Assert.AreEqual(20, car.FuelAmount);            
            car.Drive(distance);
            Assert.AreEqual(10, car.FuelAmount);
            car.Drive(distance);
            Assert.AreEqual(0, car.FuelAmount);

            Assert.Throws<InvalidOperationException>(()
                => car.Drive(distance));
        }
    }
}