using C1NUnitTest;
using C1NUnitTest.CurrencyConverter;
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
            Source.Deposit(5000);
            Destination = new BankAccount();
        }

        [Test]
        [TestCase(1)]
        [TestCase(1500)]
        [TestCase(-1)]
        public void TransferInEur(int amountInEur)
        {
            //arrange
            ICurrencyConverter converter = new CurrencyConverterStub();
            double initialBalance = Source.Balance;
            //act
            Source.TransferFromEurToRon(Destination, amountInEur, converter);
            //assert
            Assert.AreEqual(initialBalance - converter.convertFromEurToRon(amountInEur),Source.Balance);

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
