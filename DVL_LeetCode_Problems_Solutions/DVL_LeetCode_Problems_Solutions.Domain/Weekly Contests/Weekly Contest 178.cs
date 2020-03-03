using System.Collections.Generic;
using System.Linq;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// How Many Numbers Are Smaller Than the Current Number (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] arr = nums.OrderBy(n=>n).ToArray();
            var dict = new Dictionary<int,int>();
            int count = 0;
            foreach (var num in arr)
            {
                if (!dict.ContainsKey(num))
                    dict.Add(num, count);
                count++;
            }

            int[] result = new int[nums.Length];
            for (int i = 0; i < result.Length; i++)
                result[i] = dict[nums[i]];

            return result;
        }

        /// <summary>
        /// Linked List in Binary Tree (Mine - but solved later)
        /// </summary>
        /// <param name="head"></param>
        /// <param name="root"></param>
        /// <param name="mustHaveEqualValues"></param>
        /// <returns></returns>
        public static bool IsSubPath(ListNode head, TreeNode root, bool mustHaveEqualValues = false)
        {
            if (head == null)
                return true;
            if (root == null)
                return false;

            if (head.val == root.val && (IsSubPath(head.next, root.left, true) || IsSubPath(head.next, root.right, true)))
                return true;
            if (mustHaveEqualValues)
                return false;

            return IsSubPath(head, root.left) || IsSubPath(head, root.right);
        }
    }
}