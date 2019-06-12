using Anagram;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace UnitTests
{

    [TestFixture]
    public class Tests
    {
        AnagramsFinder finder = new AnagramsFinder();
        [Test]
        public void OneWord_ShouldReturnNull ()
        {
            string[] words = { "hola" };
            LinkedList<string> output = finder.Find(words);

            Assert.AreEqual(null, output.First);
        }

        [Test]
        public void TwoAnagramsWords_ShouldReturnBothWords()
        {
            string[] words = { "hola", "halo" };
            LinkedList<string> output = finder.Find(words);

            Assert.AreEqual("hola * halo", output.First.Value);
        }

        [Test]
        public void wordSorter()
        {
            Assert.AreEqual("abc", finder.wordSorter("bca"));
        }

        [Test]
        public void FourAnagrams()
        {
            string[] words = { "hola","ojs", "halo", "jso" };
            LinkedList<string> output = finder.Find(words);

            Assert.AreEqual("hola * halo", output.First.Value);
            Assert.AreEqual("ojs * jso", output.First.Next.Value);
        }

    


    }
}
