namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find Peak Element (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindPeakElement(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                if ((i - 1 < 0 || nums[i] > nums[i - 1]) && (i + 1 == nums.Length || nums[i + 1] < nums[i]))
                    return i;

            return -1;
        }
    }
}
