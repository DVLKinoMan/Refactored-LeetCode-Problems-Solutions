using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Reorder List (Mine)
        /// </summary>
        /// <param name="head"></param>
        public static void ReorderList(ListNode head)
        {
            if (head == null)
                return;

            var stack = new Stack<ListNode>();
            var currNode = head;
            int count = 0;
            while (currNode != null)
            {
                stack.Push(currNode);
                currNode = currNode.next;
                count++;
            }

            currNode = head;
            ListNode nextNode = null;
            int count2 = 0;
            while (count2 != count)
            {
                if (count2 % 2 == 0)
                {
                    nextNode = currNode.next;
                    currNode.next = stack.Pop();
                }
                else
                    currNode.next = nextNode;

                currNode = currNode.next;
                count2++;
            }

            currNode.next = null;
        }
    }
}
