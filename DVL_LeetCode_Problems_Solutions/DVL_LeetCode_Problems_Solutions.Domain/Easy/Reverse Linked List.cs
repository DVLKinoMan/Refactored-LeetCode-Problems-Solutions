using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Reverse LInked List (Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;

            ListNode last;
            Func(head, null);

            return last;

            void Func(ListNode node, ListNode parentNode)
            {
                if (node.next != null)
                    Func(node.next, node);
                else last = node;
                node.next = parentNode;
            }
        }
    }
}
