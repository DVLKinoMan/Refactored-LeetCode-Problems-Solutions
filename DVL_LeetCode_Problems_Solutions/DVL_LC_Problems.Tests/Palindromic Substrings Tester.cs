﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class PalindromicSubstringsTester
    {
        [TestMethod]
        public void Method1()
        {
            CountSubstrings("abcabc");
        }
    }
}
