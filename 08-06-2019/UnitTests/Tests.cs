using NumberInWords;
using NUnit.Framework;
using System;



namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Zero()
        {
            Translator translator = new Translator();

            Assert.AreEqual("Zero", translator.translate(0));
        }

        [Test]
        public void One()
        {
            Translator translator = new Translator();

            Assert.AreEqual("One", translator.translate(1));
        }

        [Test]
        public void Ten()
        {
            Translator translator = new Translator();

            Assert.AreEqual("Ten", translator.translate(10));
        }

        [Test]
        public void Twenty_one()
        {
            Translator translator = new Translator();

            Assert.AreEqual("Twenty One", translator.translate(21));
        }

    }
}
