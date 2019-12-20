using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class MinimumRemoveToMakeValidParenthesesTester
    {
        [TestMethod]
        public void Method1()
        {
            MinRemoveToMakeValid("lee(t(c)o)de)");
        }
    }
}
