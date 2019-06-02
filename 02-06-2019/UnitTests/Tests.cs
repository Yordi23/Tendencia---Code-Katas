using NUnit.Framework;
using StringCalculator2;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        Calculator calculator = new Calculator();

        [Test]
        public void EmptyString()
        {         
            Assert.AreEqual("0",calculator.Add(""));
        }

        [Test]
        public void OneNumber()
        {
            Assert.AreEqual("5", calculator.Add("5"));
        }

        [Test]
        public void TwoNumbers()
        {
            Assert.AreEqual("8", calculator.Add("5,3"));
        }

        [Test]
        public void FourDecimalNumbers()
        {
            Assert.AreEqual("3.3", calculator.Add("1.1,0.5,1.7"));
        }

        [Test]
        public void TwoDecimalTwoIntegerNumbers()
        {
            Assert.AreEqual("4.6", calculator.Add("1.1,0.5,1,2"));
        }

        [Test]
        public void NewlineAsSeparator()
        {
            Assert.AreEqual("6", calculator.Add("1\n2,3"));
        }
        
        [Test]
        public void NewlineAsSeparator3()
        {
            Assert.AreEqual("29", calculator.Add("1\n2,3,9,8\n5\n1"));
        }

        [Test]
        public void SeparatorFollowedBySeparator()
        {
            Assert.AreEqual("Number expected but '\n' found at position 6.", calculator.Add("175.2,\n35"));
        }
    }
}
