using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Path Sum II (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            IList<IList<int>> listlist = new List<IList<int>>();
            if (root == null)
                return listlist;
            PathSumHelper(root, 0, sum, new List<int>(), listlist);
            return listlist;
        }

        private static void PathSumHelper(TreeNode root, int sum, int neededSum, List<int> list, IList<IList<int>> listlist)
        {
            sum += root.val;
            list.Add(root.val);
            if (root.left == null && root.right == null)
                if (sum == neededSum)
                    listlist.Add(list.ToList());

            if (root.left != null)
                PathSumHelper(root.left, sum, neededSum, list, listlist);
            if (root.right != null)
                PathSumHelper(root.right, sum, neededSum, list, listlist);
            list.RemoveAt(list.Count - 1);
        }
    }
}
