using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]

    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("hola\nPedro", WordWrap2.Wrapper.Wrap("hola Pedro",4));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("sol sal\nEdificio", WordWrap2.Wrapper.Wrap("sol sal Edificio", 6));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("si\na a\nni\no", WordWrap2.Wrapper.Wrap("si a a ni o", 2));
        }
    }
}
