using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Intersection of Two Linked Lists (Mine)
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var stack1 = new Stack<ListNode>();
            var stack2 = new Stack<ListNode>();
            
            var currListNode = headA;
            while (currListNode != null)
            {
                stack1.Push(currListNode);
                currListNode = currListNode.next;
            }

            currListNode = headB;
            while (currListNode != null)
            {
                stack2.Push(currListNode);
                currListNode = currListNode.next;
            }

            ListNode fIntersection = null;
            while (stack1.Count != 0 && stack2.Count != 0 && stack1.Peek() == stack2.Peek())
            {
                fIntersection = stack1.Pop();
                stack2.Pop();
            }

            return fIntersection;
        }
    }
}
