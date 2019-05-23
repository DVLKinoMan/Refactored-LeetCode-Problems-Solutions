using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Next Greater Node In Linked List (Not Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static int[] NextLargerNodes(ListNode head)
        {
            var list = new List<int>();
            for (var curr = head; curr != null; curr = curr.next)
                list.Add(curr.val);

            var indexes=new Stack<int>();
            int[] res=new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                while (indexes.Count != 0 && list[indexes.Peek()] < list[i])
                    res[indexes.Pop()] = list[i];
                indexes.Push(i);
            }

            return res;
        }
    }
}
