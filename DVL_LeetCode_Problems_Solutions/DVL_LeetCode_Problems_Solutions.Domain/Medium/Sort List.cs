using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sort List (Not Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode SortList(ListNode head)
        {
            if (head?.next == null)
                return head;

            // step 1. cut the list to two halves
            ListNode prev = null, slow = head, fast = head;

            while (fast?.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            prev.next = null;

            // step 2. sort each half
            var l1 = SortList(head);
            var l2 = SortList(slow);

            // step 3. Merge l3 and l4
            return Merge(l1, l2);

            ListNode Merge(ListNode l3, ListNode l4)
            {
                ListNode l = new ListNode(0), p = l;

                while (l3 != null && l4 != null)
                {
                    if (l3.val < l4.val)
                    {
                        p.next = l3;
                        l3 = l3.next;
                    }
                    else
                    {
                        p.next = l4;
                        l4 = l4.next;
                    }

                    p = p.next;
                }

                if (l3 != null)
                    p.next = l3;

                if (l4 != null)
                    p.next = l4;

                return l.next;
            }
        }
    }
}
