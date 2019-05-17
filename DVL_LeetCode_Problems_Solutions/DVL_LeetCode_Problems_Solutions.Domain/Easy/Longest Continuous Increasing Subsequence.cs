namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Continuous Increasing Subsequence (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int max = 1, curr = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                    curr++;
                else
                {
                    if (max < curr)
                        max = curr;
                    curr = 1;
                }
            }

            if (curr > max)
                max = curr;

            return max;
        }
    }
}
