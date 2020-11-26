using System;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCodeTest
{
    [TestClass]
    public class UnitTestCodeTest
    {
        TestPerpermutationsClass permutationClassTest = new TestPerpermutationsClass();

        [TestMethod]
        public void TestCase1()
        {
           Assert.IsTrue(permutationClassTest.TestStrPermutationCase1());
        }

        [TestMethod]
        public void TestCase2()
        {
           Assert.IsTrue(permutationClassTest.TestStrPermutationCase2());
        }

        [TestMethod]
        public void TestCase3()
        {
            Assert.IsTrue(permutationClassTest.TestStrPermutationCase3());
        }
    }
}
