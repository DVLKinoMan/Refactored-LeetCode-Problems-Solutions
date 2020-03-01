using System.Collections.Generic;
using System.Linq;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
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

        public static bool IsSubPath(ListNode head, TreeNode root)
        {
            if (head == null)
                return true;
            if (root == null)
                return false;

            if (head.val == root.val && (IsSubPath(head.next, root.left) || IsSubPath(head.next, root.right)))
                return true;

            return IsSubPath(head, root.left) || IsSubPath(head, root.right);
        }
    }
}