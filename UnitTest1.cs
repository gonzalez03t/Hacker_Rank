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

            Assert.IsTrue(test.makeAnagram("tbbbahcdcu", "idfcbaxcccl") == 11);
        }

        [TestMethod]
        public void EqualStacksTest()
        {
            EqualStacks test = new EqualStacks();

            int[] array1 = { 1, 1, 1, 1, 2 };
            int[] array2 = { 3, 7, };
            int[] array3 = { 1, 3, 1 };

            Assert.IsTrue(test.equalStacks(array1, array2, array3) == 0);                                         
        }
    }
}
