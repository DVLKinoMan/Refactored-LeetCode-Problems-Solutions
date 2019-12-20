using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class InsertIntervalTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            Insert(new List<Interval>(), new Interval(1, 1));
        }
    }
}
