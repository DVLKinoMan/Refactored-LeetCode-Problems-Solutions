using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class Minimum_Number_of_Taps
    {
        [TestMethod]
        public void TestMethod1()
        {
            //MinTaps(7,
            //    new int[] {1, 2, 1, 0, 2, 1, 0, 1});
            //MinTaps(8,
            //    new int[] {4, 0, 0, 0, 4, 0, 0, 0, 4});
            MinTaps(9,
                new int[]
                {
                    0, 5, 0, 3, 3, 3, 1, 4, 0, 4
                });
        }
    }
}
