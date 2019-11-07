namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Non-decreasing Array (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool CheckPossibility(int[] nums)
        {
            if (nums.Length == 0)
                return true;

            bool hadModified = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[i]>=nums[i-1])
                    continue;

                if (hadModified)
                    return false;

                if (i == nums.Length - 1 || nums[i + 1] >= nums[i - 1])
                {
                    hadModified = true;
                    continue;
                }

                if (i - 2 < 0 || nums[i - 2] <= nums[i])
                {
                    hadModified = true;
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
