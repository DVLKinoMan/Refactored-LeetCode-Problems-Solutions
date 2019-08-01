namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Move Zeroes (Mine)
        /// </summary>
        /// <param name="nums"></param>
        public static void MoveZeroes(int[] nums)
        {
            int lastZeroIndex = nums.Length;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == 0)
                {
                    int i2 = i;
                    while (i2 != lastZeroIndex)
                    {
                        //swap
                        nums[i2 + 1] += nums[i2];
                        nums[i2] = nums[i2 + 1] - nums[i2];
                        nums[i2 + 1] -= nums[i2];
                        i2++;
                    }

                    lastZeroIndex--;
                }
        }
    }
}
