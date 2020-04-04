using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Remove Linked List Elements (Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode prev = null;
            var curr = head;
            while (curr != null)
            {
                if (curr.val == val)
                {
                    if (prev != null)
                        prev.next = curr.next;
                    else  head = curr.next;
                }
                else prev = curr;

                curr = curr.next;
            }

            return head;
        }
    }
}