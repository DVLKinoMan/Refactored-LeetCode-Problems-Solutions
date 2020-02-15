using System.Collections.Generic;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Linked List Cycle (Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool HasCycle(ListNode head)
        {
            var currNode = head;
            var set = new HashSet<ListNode>();

            while (currNode != null)
            {
                if (!set.Add(currNode))
                    return true;
                currNode = currNode.next;
            }

            return false;
        }
    }
}