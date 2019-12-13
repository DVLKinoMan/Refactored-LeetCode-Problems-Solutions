using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Average of Levels in Binary Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            var res = new List<double>();
            var list = new List<TreeNode>(){ root };
            while (list.Count != 0)
            {
                var newList = new List<TreeNode>();
                res.Add(list.Average(l => l.val));
                foreach (var l in list)
                {
                    if (l.left != null)
                        newList.Add(l.left);
                    if (l.right != null)
                        newList.Add(l.right);
                }

                list = newList;
            }

            return res;
        }
    }
}
