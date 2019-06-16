using Anagrams2;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]

    public class Tests
    {
        AnagramFinder finder = new AnagramFinder();

        [Test]
        public void OneWord()
        {
  
            string[] words = { "hola" };
            string[] output = finder.Find(words);

            Assert.AreEqual(null, output[0]);

        }

        [Test]
        public void TwoNotAnagramsWords()
        {
            string[] words = { "hola","mundo" };
            string[] output = finder.Find(words);

            Assert.AreEqual(null, output[0]);
            Assert.AreEqual(null, output[1]);
        }

        [Test]
        public void TwoAnagramWords()
        {
            string[] words = { "hola", "laho" };
            string[] output = finder.Find(words);

            Assert.AreEqual("hola * laho", output[0]);
        }

        [Test]
        public void SixAnagramWords_FourNotAnagrams()
        {
            string[] words = { "hola", "laho","libro", "ohla","broli", "cabeza","rolib", "pie", "persona","teclado" };
            string[] output = finder.Find(words);

            Assert.AreEqual("hola * laho * ohla", output[0]);
            Assert.AreEqual("libro * broli * rolib", output[1]);
            Assert.AreEqual(null, output[2]);
        }

    }
}
