using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        ///  Remove Zero Sum Consecutive Node from Linked List (Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode RemoveZeroSumSublists(ListNode head)
        {
            while (true)
            {
                var dic = new Dictionary<int, ListNode>();
                var currNode = head;
                int sum = 0;
                bool wasRemovedAnything = false;
                while (currNode != null)
                {
                    sum += currNode.val;

                    if (sum == 0)
                    {
                        head = currNode.next;
                        wasRemovedAnything = true;
                    }

                    if (dic.ContainsKey(sum))
                    {
                        dic[sum].next = currNode.next;
                        wasRemovedAnything = true;
                    }
                    else if (sum != 0)
                        dic.Add(sum, currNode);

                    currNode = currNode.next;
                }

                if (wasRemovedAnything == false)
                    break;
            }

            return head;
        }
    }
}
