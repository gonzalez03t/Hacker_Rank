using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hacke_Rank
{
    [TestClass]
    public class HackerRankProblems
    {
        [TestMethod]
        public void AlternatingCharactersTest()
        {
            AlternatingCharacters test = new AlternatingCharacters();

            Assert.IsTrue(test.alternatingCharacters("AAABBB") == 4);
            Assert.IsTrue(test.alternatingCharacters("AAAA") == 3);
            Assert.IsTrue(test.alternatingCharacters("BBBBB") == 4);
            Assert.IsTrue(test.alternatingCharacters("BABABA") == 0);
            Assert.IsTrue(test.alternatingCharacters("ABABABAB") == 0);
        }

        [TestMethod]
        public void MakingAnagramsTest()
        {
            MakingAnagrams test = new MakingAnagrams();

            Assert.IsTrue(test.makeAnagram("abc", "acbd") == 1);
            Assert.IsTrue(test.makeAnagram("abccf", "acbdefa") == 2);
        }

    }
}
