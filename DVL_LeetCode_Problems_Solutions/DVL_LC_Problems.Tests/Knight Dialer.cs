
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class KnightDialer
    {
        [TestMethod]
        public void TestMethod1()
        {
            int actual = KnightDialer(1);
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int actual = KnightDialer(2);
            Assert.AreEqual(20, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int actual = KnightDialer(3);
            Assert.AreEqual(46, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int actual = KnightDialer(5000);
            Assert.AreEqual(46, actual);
        }
    }
}
