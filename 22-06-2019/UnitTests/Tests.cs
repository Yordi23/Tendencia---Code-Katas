using NUnit.Framework;
using RomanNumerals;

namespace UnitTests
{
    [TestFixture]

    public class Class1
    {
        Converter converter = new Converter();
        [Test]
        public void One_ShouldReturn_I()
        {
            Assert.AreEqual("I", converter.Convert(1));
        }

        [Test]
        public void Five_ShouldReturn_V()
        {           
            Assert.AreEqual("V", converter.Convert(5));
        }

        [Test]
        public void VariousNumbers()
        {
            Assert.AreEqual("X", converter.Convert(10));
            Assert.AreEqual("L", converter.Convert(50));
            Assert.AreEqual("C", converter.Convert(100));
        }

        [Test]
        public void Three_ShouldReturn_III()
        {
            Assert.AreEqual("III", converter.Convert(3));
        }

        [Test]
        public void Four_ShouldReturn_IV()
        {
            Assert.AreEqual("IV", converter.Convert(4));
        }


        [Test]
        public void VariousNumbersII()
        {
            Assert.AreEqual("IX", converter.Convert(9));
            Assert.AreEqual("XLIX", converter.Convert(49));
            Assert.AreEqual("XXVII", converter.Convert(27));
        }
    }
}
