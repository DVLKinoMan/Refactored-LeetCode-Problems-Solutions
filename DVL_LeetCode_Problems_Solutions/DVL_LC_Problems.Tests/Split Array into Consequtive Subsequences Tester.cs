using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class Split_Array_into_Consequtive_Subsequences_Tester
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool actual = IsPossible(new int[] {3, 4, 4, 5, 6, 7, 8, 9, 10, 11});
            Assert.AreEqual(false, actual);
        }
    }
}
