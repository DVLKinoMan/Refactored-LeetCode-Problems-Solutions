using System.Collections.Generic;
using System.Linq;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Remove_Nth_Node_From_End_of_List
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var nodes = new List<ListNode>();
            var currNode = head;
            while (currNode != null)
            {
                nodes.Add(currNode);
                currNode = currNode.next;
            }
            if (nodes.Count - n - 1 >= 0)
                nodes.ElementAt(nodes.Count - n - 1).next = n != 1 ? nodes.ElementAt(nodes.Count - (n - 1)) : null;
            else
                return nodes.Count - (n - 1) >= nodes.Count ? null : nodes.ElementAt(nodes.Count - (n - 1));

            return head;
        }
    }
}
