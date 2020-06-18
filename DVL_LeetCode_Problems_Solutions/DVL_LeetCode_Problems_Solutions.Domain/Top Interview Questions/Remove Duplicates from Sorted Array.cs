namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Remove Duplicates from Sorted Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates2(int[] nums)
        {
            int j = 0;
            for (int i = 1; i < nums.Length; i++)
                if (nums[j] != nums[i])
                    nums[++j] = nums[i];

            return nums.Length == 0 ? 0 : j + 1;
        }
    }
}