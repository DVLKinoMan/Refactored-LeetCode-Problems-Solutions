using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Middle of the Linked List (Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode MiddleNode(ListNode head)
        {
            int count = 0;
            var curr = head;
            while (curr != null)
            {
                curr = curr.next;
                count++;
            }

            int edge = count / 2;
            count = 0;
            curr = head;
            while (count != edge)
            {
                curr = curr.next;
                count++;
            }

            return curr;
        }
    }
}
