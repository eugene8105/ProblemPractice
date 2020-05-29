using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test01;

namespace TestingSolutions
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAlternatingCoins()
        {
            AlternatingCoins ac = new AlternatingCoins();

            int[] a = new int[] { 1, 0, 1, 0, 1, 1 };       // should return 1

            int[] b = new int[] { 1, 1, 0, 1, 1 };          // should return 2

            int[] c = new int[] { 1, 0, 1 };                // should return 0

            int[] d = new int[] { 0, 1, 1, 0 };             // should return 2

            Assert.AreEqual(0, ac.solution(c));

        }
    }
}
