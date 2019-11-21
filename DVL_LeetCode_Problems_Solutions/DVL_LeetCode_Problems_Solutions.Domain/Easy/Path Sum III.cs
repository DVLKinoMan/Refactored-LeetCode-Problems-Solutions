using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Path Sum III (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static int PathSum(TreeNode root, int sum)
        {
            var dict = new Dictionary<int, int>();
            dict.Add(0, 1);
            return Dfs(root, 0);

            int Dfs(TreeNode node, int currSum)
            {
                if (node == null)
                    return 0;

                int res = 0;
                currSum += node.val;
                if (dict.ContainsKey(currSum - sum))
                    res += dict[currSum - sum];

                if (dict.ContainsKey(currSum))
                    dict[currSum] += 1;
                else dict.Add(currSum, 1);

                res += Dfs(node.left, currSum) + Dfs(node.right, currSum);

                dict[currSum]--;

                return res;
            }
        }
    }
}
