using C1NUnitTest;
using NUnit.Framework;

namespace NUnitTestingC1
{
    [TestFixture]
    class BankAccountTesting
    {
        BankAccount Source;
        BankAccount Destination;


        [SetUp]
        public void Setup()
        {
            //arrange
            Source = new BankAccount();
            Destination = new BankAccount();
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(10001)]
        [TestCase(1)]
        public void DepositTestMethod(double amount)
        {
            //assert
            double currentBalance = Destination.Balance;
            //act
            Destination.Deposit(amount);
            //assert
            Assert.AreEqual(amount + currentBalance, Destination.Balance);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(10001)]
        [TestCase(1)]
        public void WithdrawTestMethod(double amount)
        {
            //arrange
            Source.Deposit(5000);
            double currentBalance = Source.Balance;
            //act
            Source.Withdraw(amount);
            //assert
            Assert.AreEqual(currentBalance-amount, Source.Balance);
        }

        [Test]
        public void TransferTest([Range(0,10000,1000)]double amount)
        {
            //arrange
            Source.Deposit(5000);
            double currentBalance = Source.Balance;
            //act
            Source.Transfer(Destination, amount);
            //assert
            Assert.That(Source.Balance == currentBalance - amount);
        }

        [TearDown]
        public void CleanUp()
        {
            Source = null;
            Destination = null;
            System.Console.WriteLine("Finished test");
        }
    }
}
