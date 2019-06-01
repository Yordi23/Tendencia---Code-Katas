using NUnit.Framework;
using StringCalculator;

namespace UnitTests
{
    [TestFixture]
    public class Class1
    {
        Calculator calculator = new Calculator();

        [Test]
        public void EmptyString()
        {
            Assert.AreEqual("0", calculator.Add(""));
        }

        [Test]
        public void OneNumber()
        {
            Assert.AreEqual("5", calculator.Add("5"));
        }

        [Test]
        public void TwoNumbers()
        {
            Assert.AreEqual("9", calculator.Add("2,7"));
        }

        [Test]
        public void ThreeNumbers()
        {
            Assert.AreEqual("15", calculator.Add("5,9,1"));
        }

        [Test]
        public void FourDecimalNumbers()
        {
            Assert.AreEqual("4.4", calculator.Add("1.1,0.5,0.5,2.3"));
        }
    }
}
