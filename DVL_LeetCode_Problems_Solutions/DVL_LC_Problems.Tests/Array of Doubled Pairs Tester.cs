﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class ArrayOfDoubledPairsTester
    {
        [TestMethod]
        public void Method1()
        {
            CanReorderDoubled(new int[]
            {
                7, -15, -15, 23, -3, 80, -35, 40, 68, 22, 44, 98, 20, 0, -34, 8, 40, 41, 16, 46, 16, 49, -6, -11, 35,
                -15, -74, 72, -8, 60, 40, -2, 0, -6, 34, 14, -16, -92, 54, 14, -68, 82, -30, 50, 22, 25, 16, 70, -1,
                -96, 11, 45, 54, 40, 92, -35, 29, 80, 46, -30, 27, 7, -70, -37, 41, -46, -98, 1, -33, -24, -86, -70, 80,
                -43, 98, -49, 30, 0, 27, 2, 82, 36, 0, -48, 3, -100, 58, 32, 90, -22, -50, -12, 36, 6, -3, -66, 72, 8,
                49, -30
            });

        }
    }
}
