using System.Collections.Generic;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    public class Balance_a_Binary_Search_Tree
    {
        /// <summary>
        /// Balance a Binary Search Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        // ReSharper disable once InconsistentNaming
        public static TreeNode BalanceBST(TreeNode root)
        {
            var list = new List<TreeNode>();
            Dfs(root);
            var arr = list.ToArray();
            return BalancedRoot(0, arr.Length - 1);

            TreeNode BalancedRoot(int startIndex, int endIndex)
            {
                if (startIndex > endIndex)
                    return null;

                int index = (startIndex + endIndex) / 2;
                arr[index].left = BalancedRoot(startIndex, index - 1);
                arr[index].right = BalancedRoot(index + 1, endIndex);

                return arr[index];
            }
            
            void Dfs(TreeNode node)
            {
                if (node == null)
                    return;
                
                Dfs(node.left);
                list.Add(node);
                Dfs(node.right);
            }
        }
    }
}