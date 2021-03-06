﻿using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class IncreasingOrderSearchTreeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var node = IncreasingBST(
                new TreeNode(1)
                {
                    left = new TreeNode(2)
                    {
                        left = new TreeNode(3),
                        right = new TreeNode(4)
                    },
                    right = new TreeNode(5)
                }
                );

            Assert.AreEqual(1, -1);
        }
    }
}
