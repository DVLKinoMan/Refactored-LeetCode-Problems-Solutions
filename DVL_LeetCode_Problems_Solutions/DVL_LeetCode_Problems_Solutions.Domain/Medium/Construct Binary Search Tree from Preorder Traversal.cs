using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Construct Binary Search Tree from Preorder Treversal (Not mine Solution)
        /// </summary>
        /// <param name="preorder"></param>
        /// <returns></returns>
        public static TreeNode BstFromPreorder(int[] preorder)
        {
            int i = 0;
            return BstFromPreOrderHelper(preorder, int.MaxValue, ref i);
        }

        private static TreeNode BstFromPreOrderHelper(int[] arr, int bound, ref int i)
        {
            if (arr.Length == i || arr[i] > bound)
                return null;

            TreeNode root = new TreeNode(arr[i++]);
            root.left = BstFromPreOrderHelper(arr, root.val, ref i);
            root.right = BstFromPreOrderHelper(arr, bound, ref i);
            return root;
        }
    }
}
