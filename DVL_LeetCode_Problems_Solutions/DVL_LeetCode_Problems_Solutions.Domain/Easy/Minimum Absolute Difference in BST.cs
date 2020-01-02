using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Absolute Difference in BST (Mine is commented)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int GetMinimumDifference(TreeNode root)
        {
            //My version
            //var list = new List<TreeNode> { root };
            //int min = int.MaxValue;
            //while (list.Count != 0)
            //{
            //    var f = list.First();
            //    if (f.left != null)
            //    {
            //        list.Add(f.left);
            //        var curr = f.left;
            //        while (curr != null)
            //        {
            //            min = Math.Min(min, Math.Abs(f.val - curr.val));
            //            curr = curr.right;
            //        }
            //    }
            //    if (f.right != null)
            //    {
            //        list.Add(f.right);
            //        var curr = f.right;
            //        while (curr != null)
            //        {
            //            min = Math.Min(min, Math.Abs(f.val - curr.val));
            //            curr = curr.left;
            //        }
            //    }
            //    list.RemoveAt(0);
            //}

            //return min;

            int min = int.MaxValue;
            TreeNode prev = null;

            InOrder(root);
            return min;

            void InOrder(TreeNode node)
            {
                if (node == null)
                    return;
                InOrder(node.left);
                if (prev != null)
                    min = Math.Min(min, node.val - prev.val);
                prev = node;
                InOrder(node.right);
            }
        }
    }
}
