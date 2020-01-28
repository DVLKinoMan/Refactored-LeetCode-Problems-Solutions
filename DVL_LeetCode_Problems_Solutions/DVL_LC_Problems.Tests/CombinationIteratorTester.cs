using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class CombinationIteratorTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            var iterator = new CombinationIterator("chp", 1);

            var k1 = iterator.HasNext(); 
            var k2 = iterator.Next(); // returns "ab"
            var k3 = iterator.HasNext();// returns "ab"
            var k4 = iterator.HasNext(); // returns true
            var k5 = iterator.Next(); // returns true
            var k6 = iterator.Next(); // returns "ac"
            var k7 = iterator.HasNext(); // returns "bc"
            var k8 = iterator.HasNext(); // returns false
            var k9 = iterator.HasNext(); // returns false
        }
    }
}
