using NUnit.Framework;
using RomanNumerals2;

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
        public void Ten_ShouldReturn_X()
        {
            Assert.AreEqual("X", converter.Convert(10));
        }

        [Test]
        public void VariousNumbers()
        {
            Assert.AreEqual("V", converter.Convert(5));
            Assert.AreEqual("L", converter.Convert(50));
            Assert.AreEqual("C", converter.Convert(100));
            Assert.AreEqual("D", converter.Convert(500));
            Assert.AreEqual("M", converter.Convert(1000));
        }

        [Test]
        public void _15_ShouldReturn_XV()
        {
            Assert.AreEqual("XV", converter.Convert(15));
        }

        [Test]
        public void _13_ShouldReturn_XIII()
        {
            Assert.AreEqual("XIII", converter.Convert(13));
        }

        [Test]
        public void _34_ShouldReturn_XXXIV()
        {
            Assert.AreEqual("XXXIV", converter.Convert(34));
        }

        [Test]
        public void _41_ShouldReturn_XLI()
        {
            Assert.AreEqual("XLI", converter.Convert(41));
        }

        [Test]
        public void VariousNumbers2()
        {
            Assert.AreEqual("XC", converter.Convert(90));
            Assert.AreEqual("CD", converter.Convert(400));
            Assert.AreEqual("CM", converter.Convert(900));
            Assert.AreEqual("IX", converter.Convert(9));
        }

        [Test]
        public void VariousNumbers3()
        {
            Assert.AreEqual("MMXVIII", converter.Convert(2018));
            Assert.AreEqual("MMM", converter.Convert(3000));
            Assert.AreEqual("MDCCCLXIII", converter.Convert(1863));
            Assert.AreEqual("CMXLIX", converter.Convert(949));
        }

    }
}
