using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        ///  Delete Node in a Linked List (Not Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <param name="node"></param>
        public static void DeleteNode(ListNode node)
        {
            node.val=node.next.val;
            node.next=node.next.next;
        }
    }
}