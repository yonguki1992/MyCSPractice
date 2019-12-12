using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex191209;
using System;

namespace ExTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(new Solution191209().solution(new int[] { 6, 0, 1, 5, 3 }), 3);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(new Solution191209().solution(new int[] { 4, 3, 3, 3, 3 }), 3);
        }
    }
}
