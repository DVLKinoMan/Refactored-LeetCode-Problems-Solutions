using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Trim a Binary Search Tree (Mine and My Implementation)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="L"></param>
        /// <param name="R"></param>
        /// <returns></returns>
        public static TreeNode TrimBST(TreeNode root, int L, int R)
        {
            //My Version
            //return Dfs(root, null);

            //TreeNode Dfs(TreeNode curr, TreeNode parent, bool left = false)
            //{
            //    if (curr == null)
            //        return null;
            //    if (curr.val < L)
            //    {
            //        if (parent != null)
            //        {
            //            if (left)
            //                parent.left = curr.right;
            //            else parent.right = curr.right;
            //        }

            //        return Dfs(curr.right, parent, left);
            //    }
            //    else if (curr.val > R)
            //    {
            //        if (parent != null)
            //        {
            //            if (left)
            //                parent.left = curr.left;
            //            else parent.right = curr.left;
            //        }

            //        return Dfs(curr.left, parent, left);
            //    }
            //    else
            //    {
            //        Dfs(curr.left, curr, true);
            //        Dfs(curr.right, curr, false);

            //        return curr;
            //    }
            //}

            if (root == null)
                return null;
            if (root.val < L)
                return TrimBST(root.right, L, R);
            if (root.val > R)
                return TrimBST(root.left, L, R);

            root.left = TrimBST(root.left, L, R);
            root.right = TrimBST(root.right, L, R);

            return root;
        }
    }
}
