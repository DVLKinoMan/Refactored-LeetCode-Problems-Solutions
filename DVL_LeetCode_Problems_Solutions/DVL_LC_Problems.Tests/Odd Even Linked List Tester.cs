using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class OddEvenLinkedListTester
    {
        [TestMethod]
        public void Method1()
        {
            OddEvenList(new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            });
        }
    }
}
