using NUnit.Framework;
using System;
using WordWrap;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public static void Test1()
        {
            Wrapper wrapper = new Wrapper();
            Assert.AreEqual("hola\nJuan", WordWrap.Wrapper.Wrap("hola Juan", 4));
        }

        [Test]
        public static void Test2()
        {
            Wrapper wrapper = new Wrapper();
            Assert.AreEqual("si no\nhola", WordWrap.Wrapper.Wrap("si no hola", 4));
        }

    }
}
