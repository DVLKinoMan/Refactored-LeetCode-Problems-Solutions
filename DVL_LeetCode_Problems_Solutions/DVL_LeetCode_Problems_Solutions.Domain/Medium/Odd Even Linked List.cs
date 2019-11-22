using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Odd Even Linked List (Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode OddEvenList(ListNode head)
        {
            if (head?.next == null)
                return head;

            var oddNode = head;
            var evenNode = head.next;
            var firstEvenNode = head.next;
            var currNode = evenNode.next;

            if (currNode == null)
                return head;

            bool isEven = false;
            while (true)
            {
                if (isEven)
                {
                    evenNode.next = currNode;
                    evenNode = evenNode.next;
                }
                else
                {
                    oddNode.next = currNode;
                    oddNode = oddNode.next;
                }

                if (currNode.next == null)
                {
                    oddNode.next = firstEvenNode;
                    evenNode.next = null;
                    break;
                }
                currNode = currNode.next;
                isEven = !isEven;
            }

            return head;
        }
    }
}
