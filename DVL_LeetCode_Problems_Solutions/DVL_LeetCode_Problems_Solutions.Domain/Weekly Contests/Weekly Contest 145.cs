using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Relative Sort Array (Mine)
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var set = new HashSet<int>(arr2);
            var dic = new Dictionary<int, int>();
            var list = new List<int>();
            foreach (var num in arr1)
            {
                if (set.Contains(num))
                {
                    if (dic.ContainsKey(num))
                        dic[num]++;
                    else
                        dic.Add(num, 1);
                }
                else list.Add(num);
            }

            list.Sort();
            int i = 0;
            foreach (var num in arr2)
            {
                list.InsertRange(i, Enumerable.Repeat(num, dic[num]));
                i += dic[num];
            }

            return list.ToArray();
        }

        /// <summary>
        /// Lowest Common Ancestor of Deepest Leaves (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static TreeNode LcaDeepestLeaves(TreeNode root)
        {
            var (d, c) = GetDepthAndNumber(root, 0);
            int currCount = 0;
            return rec(root, 0, d, ref currCount, c);
        }

        private static (int, int) GetDepthAndNumber(TreeNode root, int depth)
        {
            if (root == null)
                return (depth - 1, 1);
            if (root.left == null && root.right == null)
                return (depth, 1);

            var left = GetDepthAndNumber(root.left, depth + 1);
            var right = GetDepthAndNumber(root.right, depth + 1);

            if (left.Item1 > right.Item1)
                return (left.Item1, left.Item2);
            else if (left.Item1 < right.Item1)
                return (right.Item1, right.Item2);
            else return (left.Item1, left.Item2 + right.Item2);
        }

        private static TreeNode rec(TreeNode root, int currDepth, int depth, ref int currCount, int count)
        {
            if (root == null)
                return null;
            if (currDepth == depth)
                currCount++;

            int currCountBefore = currCount;
            var left = rec(root.left, currDepth + 1, depth, ref currCount, count);
            var right = rec(root.right, currDepth + 1, depth, ref currCount, count);

            var node = left ?? right;
            if (node != null)
                return node;

            if ((currCountBefore == 0 || count == 1) && currCount == count)
                return root;

            return null;
        }
    }
}
