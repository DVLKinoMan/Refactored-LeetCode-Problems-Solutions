using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class SatisfiabilityOfEqualityEquationsTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            EquationsPossible(new string[]
            {
                "a==b", "e==c", "b==c", "a!=e"
            });
        }
    }
}
