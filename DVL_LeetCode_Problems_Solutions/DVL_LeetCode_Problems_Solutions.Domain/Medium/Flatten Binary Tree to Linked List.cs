using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        //private TreeNode prev = null;

        /// <summary>
        /// Flatten Binary Tree to Linked List (Mine)
        /// </summary>
        /// <param name="root"></param>
        public static void Flatten(TreeNode root)
        {
            if (root == null)
                return;

            var list = new List<TreeNode>();
            Dfs(root);
            var currNode = root;
            for (int i = 1; i < list.Count; i++)
            {
                currNode.right = list[i];
                currNode.left = null;
                currNode = list[i];
            }

            currNode.left = null;
            currNode.right = null;
            
            void Dfs(TreeNode node)
            {
                if (node == null)
                    return;

                list.Add(node);
                Dfs(node.left);
                Dfs(node.right);
            }

            //Not mine
            //if (root == null)
            //    return;
            //Flatten(root.right);
            //Flatten(root.left);
            //root.right = prev;
            //root.left = null;
            //prev = root;
        }
    }
}
