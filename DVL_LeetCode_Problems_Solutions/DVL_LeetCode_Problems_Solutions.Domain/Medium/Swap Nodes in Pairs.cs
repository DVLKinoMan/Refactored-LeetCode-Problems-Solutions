using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Swap_Nodes_in_Pairs
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null)
                return null;

            var prevNode = head;
            var result = prevNode.next ?? prevNode;

            ListNode prevPrevNode = null;
            while (prevNode != null)
            {
                var nextNode = prevNode.next;
                if (nextNode != null)
                {
                    if (prevPrevNode != null)
                        prevPrevNode.next = nextNode;
                    prevNode.next = nextNode.next;
                    nextNode.next = prevNode;
                    prevPrevNode = prevNode;
                }
                prevNode = prevNode.next;
            }

            return result;
        }
    }
}
