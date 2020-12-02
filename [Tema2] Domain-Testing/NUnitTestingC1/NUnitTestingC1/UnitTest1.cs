using NUnit.Framework;
using C1NUnitTest;

namespace NUnitTestingC1
{
    public class Tests
    {
        Account source;
        Account destination;

        [SetUp]
        public void Setup()
        {
            //arrange
            source = new Account();
            source.Deposit(200.00f);
            destination = new Account();
            destination.Deposit(150.00f);

        }

        /*[Test]*/
        public void Test1()
        {
            //act
            source.TransferFunds(destination, 90.00f);

            //assert
            Assert.AreEqual(240.00f, destination.Balance);
            Assert.AreEqual(110.00f, source.Balance);
        }

        /*[Test] 
        [TestCase(200,0,70)]
        [TestCase(200,0,189)]
        [TestCase(200,0,1)]*/
        public void TransferMinFunds(int a, int b, int c)
        {
            //arrange
            Account source = new Account();
            source.Deposit(a);
            Account destination = new Account();
            destination.Deposit(b);

            //act
            source.TransferMinFunds(destination, c);

            //assert
            Assert.AreEqual(c, destination.Balance);
        }


        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("Tear down");
        }
    }
}