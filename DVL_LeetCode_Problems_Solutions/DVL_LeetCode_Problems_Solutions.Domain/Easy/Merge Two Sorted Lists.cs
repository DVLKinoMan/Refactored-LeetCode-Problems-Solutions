using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Merge_Two_Sorted_Lists
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;

            var currLeftNode = l1;
            var currRigthNode = l2;
            ListNode head;

            if (currLeftNode != null && (currRigthNode == null || currLeftNode.val < currRigthNode.val))
            {
                head = currLeftNode;
                currLeftNode = head.next;
            }
            else
            {
                head = currRigthNode;
                currRigthNode = head.next;
            }

            ListNode currNode;
            currNode = head;
            while (currLeftNode != null || currRigthNode != null)
            {
                if (currLeftNode != null && (currRigthNode == null || currLeftNode.val < currRigthNode.val))
                {
                    currNode.next = currLeftNode;
                    currLeftNode = currLeftNode.next;
                }
                else
                {
                    currNode.next = currRigthNode;
                    currRigthNode = currRigthNode.next;
                }
                currNode = currNode.next;
            }

            return head;
        }
    }
}
