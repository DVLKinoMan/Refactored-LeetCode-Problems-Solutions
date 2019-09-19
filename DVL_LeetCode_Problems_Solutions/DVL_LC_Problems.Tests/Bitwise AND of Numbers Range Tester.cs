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
    public class Bitwise_AND_of_Numbers_Range_Tester
    {
        [TestMethod]
        public void TestMethod1()
        {
            int answer = BrokenCalc(2, 3);
            Assert.AreEqual(2, answer);
        }
    }
}
