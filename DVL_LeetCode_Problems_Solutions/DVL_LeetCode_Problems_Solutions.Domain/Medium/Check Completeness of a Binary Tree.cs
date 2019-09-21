using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Check Completeness of a Binary Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsCompleteTree(TreeNode root)
        {
            if (root == null)
                return true;

            //List of last level node depths
            var depths = new List<int>();

            void dfs(TreeNode node, int depth)
            {
                if (node.left == null && node.right == null)
                {
                    depths.Add(depth);
                    return;
                }

                if (node.left != null)
                    dfs(node.left, depth + 1);
                else depths.Add(depth);

                if (node.right != null)
                    dfs(node.right, depth + 1);
                else depths.Add(depth);
            }

            //Run dfs to find depths of last level nodes
            dfs(root, 0);

            //First index of last level node depth which is different than depths[0]
            int index = depths.Select((l, i) => i).Where(i => depths[i] != depths[0]).FirstOrDefault();

            //If there is not such index all depths of last level nodes are equal
            if (index == 0)
                return true;

            //Checking if in last level all nodes are as far left as possible
            return depths[index] < depths[0] && !depths.Where((l, i) => i >= index && l != depths[index]).Any();
        }
    }
}
