using NumberInWords2;
using NUnit.Framework;


namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Zero ()
        {
            Translator translator = new Translator();
            Assert.AreEqual("Zero", translator.Translate("0"));
        }

        [Test]
        public void One()
        {
            Translator translator = new Translator();
            Assert.AreEqual("One", translator.Translate("1"));
        }

        [Test]
        public void Twenty_One()
        {
            Translator translator = new Translator();
            Assert.AreEqual("Twenty One", translator.Translate("21"));
        }

        [Test]
        public void Fifty_Five()
        {
            Translator translator = new Translator();
            Assert.AreEqual("Fifty Five", translator.Translate("55"));
        }

        [Test]
        public void Ninety_Nine()
        {
            Translator translator = new Translator();
            Assert.AreEqual("Ninety Nine", translator.Translate("99"));
        }

        [Test]
        public void One_Hundred()
        {
            Translator translator = new Translator();
            Assert.AreEqual("One Hundred", translator.Translate("100"));
        }

        [Test]
        public void Two_Hundred_Forty_Eight()
        {
            Translator translator = new Translator();
            Assert.AreEqual("Two Hundred Forty Eight", translator.Translate("248"));
        }
    }
}
