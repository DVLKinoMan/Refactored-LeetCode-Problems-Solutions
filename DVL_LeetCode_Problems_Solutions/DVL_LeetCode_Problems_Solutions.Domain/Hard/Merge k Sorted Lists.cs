using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        //My version. Right but it is better not to create List
        //public static ListNode MergeKLists(ListNode[] lists)
        //{
        //    var list = lists.ToList();
        //    while (list.Count > 1)
        //    {
        //        var first = list.ElementAt(0);
        //        var second = list.ElementAt(1);
        //        var merged = MergeTwoLists(first, second);
        //        list.RemoveAt(0);
        //        list.RemoveAt(0);
        //        list.Add(merged);
        //    }

        //    return list.Count == 0 ? null : list.First();
        //}

        /// <summary>
        /// Merge_k_Sorted_Lists
        /// </summary>
        /// <param name="lists"></param>
        /// <returns></returns>
        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
                return null;

            int interval = 1;
            while (interval < lists.Length)
            {
                for (int i = 0; i < lists.Length; i += interval * 2)
                    if (i + interval < lists.Length)
                        lists[i] = MergeTwoLists2(lists[i], lists[i + interval]);
                interval *= 2;
            }

            return lists[0];
        }

        private static ListNode MergeTwoLists2(ListNode l1, ListNode l2)
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
