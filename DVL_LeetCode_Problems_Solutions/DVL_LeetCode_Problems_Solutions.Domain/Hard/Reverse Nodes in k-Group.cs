using System.Collections.Generic;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Reverse_Nodes_in_k_Group
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null)
                return null;

            var current = head;
            var list = new List<ListNode>();
            while (current != null)
            {
                list.Add(current);
                current = current.next;
            }

            int count = 0;
            while (count != list.Count / k)
            {
                int firstIndex = count * k;
                int lastIndex = (count + 1) * k - 1;
                for (int i = 0; i < k / 2; i++)
                {
                    var first = list[firstIndex + i];
                    list[firstIndex + i] = list[lastIndex - i];
                    list[lastIndex - i] = first;
                }

                count++;
            }

            for (int i = 0; i < list.Count; i++)
                list[i].next = i + 1 < list.Count ? list[i + 1] : null;

            return list[0];
        }
    }
}
