using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Palindrome Linked List (Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool IsPalindrome(ListNode head)
        {
            if (head == null)
                return false;

            return IsPalindromeHelper(ref head, head);
        }

        private static bool IsPalindromeHelper(ref ListNode fNode, ListNode currNode)
        {
            if (currNode.next != null && !IsPalindromeHelper(ref fNode, currNode.next))
                return false;

            if (fNode.val != currNode.val)
                return false;

            fNode = fNode.next;

            return true;
        }
    }
}
