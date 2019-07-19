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
            int[] array2 = { 3, 7 };
            int[] array3 = { 1, 3, 1 };

            Assert.IsTrue(test.equalStacks(array1, array2, array3) == 0);                                         
        }

        [TestMethod]
        public void MinimumSwapsTest()
        {
            MinimumSwaps2 test = new MinimumSwaps2();

            int[] arr = { 1, 3, 5, 2, 4, 6, 7};

            Assert.IsTrue(test.minimumSwaps(arr) == 3);
        }

        [TestMethod]
        public void factorialTest()
        {
            factorial test = new factorial();

            Assert.IsTrue(test.factorialF(5) == 120);
        }

        [TestMethod]
        public void stringReverseTest()
        {
            stringReverseRecursion test = new stringReverseRecursion();
            string str = "jesus";

            Assert.IsTrue(test.reverseString(str) == "susej");
        }
    }
}
