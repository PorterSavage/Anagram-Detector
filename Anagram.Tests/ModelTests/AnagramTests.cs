using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;

namespace Anagram.Tests
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void IsAnagram_CompareUserStrings_False()
        {
            AnagramClass testAnagram = new AnagramClass();
            Assert.AreEqual(false, testAnagram.IsWord("bread", "dough"));
        }
        
    }
}