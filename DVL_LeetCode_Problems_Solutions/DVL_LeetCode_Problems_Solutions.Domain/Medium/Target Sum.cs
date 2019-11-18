namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Target Sum (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int FindTargetSumWays(int[] nums, int S)
        {
            int count = 0;
            Dfs(0,0);
            return count;

            void Dfs(int currSum, int index)
            {
                if (index == nums.Length)
                {
                    if(currSum == S)
                        count++;
                    return;
                }

                currSum += nums[index];
                Dfs(currSum, index + 1);
                currSum -= 2 * nums[index];
                Dfs(currSum, index + 1);
            }
        }
    }
}
