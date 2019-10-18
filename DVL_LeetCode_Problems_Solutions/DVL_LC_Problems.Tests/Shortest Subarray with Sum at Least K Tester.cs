using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class Shortest_Subarray_with_Sum_at_Least_K_Tester
    {
        [TestMethod]
        public void TestMethod1()
        {
            //MaxDistToClosest(new int[] {1, 0, 0, 0, 1, 0, 1});
            var res = ShortestSubarray(new[] { 84, -37, 32, 40, 95 }, 167);
            Assert.AreEqual(3, res);
        }
    }
}
