using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Width of Binary Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int WidthOfBinaryTree(TreeNode root)
        {
            var treeNodes = new List<(TreeNode node, int index)>() {(root, 0)};
            int maxWidth = 1;

            while (treeNodes.Count != 0)
            {
                var newList = new List<(TreeNode node,int index)>();
                foreach (var treeNode in treeNodes)
                {
                    if (treeNode.node.left != null)
                        newList.Add((treeNode.node.left, treeNode.index * 2));
                    if (treeNode.node.right != null)
                        newList.Add((treeNode.node.right, treeNode.index * 2 + 1));
                }

                if (newList.Count > 0)
                    maxWidth = Math.Max(maxWidth, newList[newList.Count - 1].index - newList[0].index + 1);
                treeNodes = newList;
            }

            return maxWidth;
        }
    }
}
