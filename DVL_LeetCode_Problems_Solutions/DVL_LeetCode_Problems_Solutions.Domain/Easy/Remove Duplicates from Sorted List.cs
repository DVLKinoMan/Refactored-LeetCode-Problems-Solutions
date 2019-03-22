using System.Collections.Generic;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static ListNode DeleteDuplicatesInNonSortedList(ListNode head)
        {
            if (head == null)
                return head;

            var result = head;
            var curr = head;

            var set = new HashSet<int>();
            set.Add(head.val);
            var prev = head;
            curr = head.next;
            while (curr != null)
            {
                if (!set.Add(curr.val))
                    prev.next = curr.next;
                else prev = curr;
                curr = curr.next;
            }

            return result;
        }

        /// <summary>
        /// Remove Duplicates from Sorted List
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return head;
            
            var curr = head;
            while (curr.next != null)
            {
                if (curr.next.val == curr.val)
                    curr.next = curr.next.next;
                else curr = curr.next;
            }

            return head;
        }
    }
}
