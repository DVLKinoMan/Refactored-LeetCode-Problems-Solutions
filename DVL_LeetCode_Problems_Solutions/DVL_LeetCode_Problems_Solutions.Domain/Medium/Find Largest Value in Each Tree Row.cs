using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find Largest Value in Each Tree Row (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> LargestValues(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
                return result;

            var list = new List<TreeNode>() { root };
            while (list.Count != 0)
            {
                int maxInRow = list[0].val;
                var newList = new List<TreeNode>();
                foreach (var n in list)
                {
                    maxInRow = Math.Max(maxInRow, n.val);
                    if (n.left != null)
                        newList.Add(n.left);
                    if (n.right != null)
                        newList.Add(n.right);
                }
                list = newList;
                result.Add(maxInRow);
            }

            return result;
        }
    }
}
