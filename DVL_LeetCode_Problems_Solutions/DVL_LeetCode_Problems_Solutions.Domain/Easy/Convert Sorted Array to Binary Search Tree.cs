using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Convert Sorted Array to Binary Search Tree (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBSTHelper(nums, 0, nums.Length - 1);
        }

        private static TreeNode SortedArrayToBSTHelper(int[] nums, int i, int j)
        {
            if (i >= j)
                return null;
            int index = (i + j) / 2;

            var node = new TreeNode(nums[index]);
            node.left = SortedArrayToBSTHelper(nums, i, index);
            node.right = SortedArrayToBSTHelper(nums, index, j);

            return node;
        }
    }
}
