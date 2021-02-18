namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Count of Range Sum (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static int CountRangeSum(int[] nums, int lower, int upper)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                long sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum >= lower && sum <= upper)
                        count++;
                }
            }

            return count;
        }
    }
}
