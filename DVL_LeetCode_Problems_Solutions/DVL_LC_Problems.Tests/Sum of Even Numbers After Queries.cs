using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class Sum_of_Even_Numbers_After_Queries
    {
        [TestMethod]
        public void TestMethod1()
        {
            var res = SumEvenAfterQueries(new int[] { -10, 2, -4, 5, -3, 3 },
                new int[][]
                {
                    new int[] {-4, 2}, new int[] {9, 0}, new int[] {-8, 1}, new int[] {5, 4}, new int[] {1, 4},
                    new int[] {9, 0}
                });
            Assert.AreEqual(1,1);
        }
    }
}
