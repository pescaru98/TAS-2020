using C1NUnitTest;
using C1NUnitTest.CurrencyConverter;
using NUnit.Framework;
using Moq;
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
            Source.Deposit(5000);
            Destination = new BankAccount();
        }

        [Test]
        [TestCase(10)]
        [TestCase(-1)]
        [TestCase(3000)]

        public void TransferInEur(int amountInEur)
        {
            //arrange
            double InitialBalance = Source.Balance;
            double ConversionRate = 4.87f;
            var converterMock = new Mock<ICurrencyConverter>();

            
            converterMock.Setup(obj => obj.convertFromEurToRon(amountInEur)).Returns(amountInEur * ConversionRate);

            //act
            Source.TransferFromEurToRon(Destination, amountInEur, converterMock.Object);

            //assert
            Assert.AreEqual(InitialBalance - amountInEur * ConversionRate, Source.Balance);
            converterMock.Verify(obj => obj.convertFromEurToRon(amountInEur), Times.AtLeastOnce());
        }

        [Test]
        [TestCase(5)]
        [TestCase(-1)]
        [TestCase(10000)]
        [TestCase(10001)]
        public void SpyTestDeposit(int amount)
        {
            //arrange
            BankAccountSpy bankAccount = new BankAccountSpy();
            double initialBalance = bankAccount.Balance;
            //act
            bankAccount.Deposit(amount);
            //assert
            Assert.AreEqual(initialBalance + amount, bankAccount.Balance);
            Assert.IsTrue(bankAccount.countDeposit == 1);
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
