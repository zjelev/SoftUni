using NUnit.Framework;

namespace BankAccount.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //Arrange - create objects
            Initialize();
        }

        private Account account;
        public void Initialize()
        {
            this.account = new Account(5000m);
        }

        [Test]
        public void AccountInitializeWithPositiveValue()
        {
            
            //Act - invoke the test case with parameteres

            //Assert - check actual-expected
            Assert.That(this.account.Amount, Is.EqualTo(5000m));
        }

        [Test]
        public void DepositShouldAddMoney()
        {
            //Act
            account.Deposit(1000m);

            Assert.AreEqual(account.Amount,  6000m);
        }
    }
}