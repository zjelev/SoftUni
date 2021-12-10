using NUnit.Framework;

namespace BankAccount.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void AccountInitializeWithPositivevalue()
        {
            Bank.BankAccount account = new Bank.BankAccount(5000m);

            Assert.That(account, Is.EqualTo(5000m));
        }
    }
}