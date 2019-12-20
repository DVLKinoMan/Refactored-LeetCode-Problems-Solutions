﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class StoneGameIITester
    {
        [TestMethod]
        public void Method1()
        {
            int d = StoneGameII(new int[] { 2, 7, 9, 4, 4 });

            Assert.AreEqual(10, d);
        }
    }
}
