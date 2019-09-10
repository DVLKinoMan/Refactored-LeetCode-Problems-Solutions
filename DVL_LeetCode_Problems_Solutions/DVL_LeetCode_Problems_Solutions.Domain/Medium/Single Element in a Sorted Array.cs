namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Single Element in a Sorted Array (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNonDuplicate(int[] nums)
        {
            int xor = nums[0];
            for (int i = 1; i < nums.Length; i++)
                xor ^= nums[i];

            return xor;
        }

        /// <summary>
        /// Single Element in a Sorted Array (Mine - better)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNonDuplicate2(int[] nums)
        {
            for (int i = 1; i < nums.Length; i += 2)
                if (nums[i] != nums[i - 1])
                    return i == 1 ? nums[i - 1] : nums[i];

            return nums[nums.Length - 1];
        }
    }
}
