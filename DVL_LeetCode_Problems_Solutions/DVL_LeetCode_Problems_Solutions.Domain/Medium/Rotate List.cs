using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Rotate List
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null)
                return head;

            var curr = head;
            int count = 1;
            while (curr.next != null)
            {
                curr = curr.next;
                count++;
            }

            curr.next = head;

            int c = 1, index = count - (k % count);
            curr = head;
            while (c != index)
            {
                curr = curr.next;
                c++;
            }

            var result = curr.next;
            curr.next = null;

            return result;
        }
    }
}
