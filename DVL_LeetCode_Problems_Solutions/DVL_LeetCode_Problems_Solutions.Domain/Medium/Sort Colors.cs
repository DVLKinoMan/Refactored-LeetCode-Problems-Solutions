namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sort Colors (My Solution Not Fast)
        /// </summary>
        /// <param name="nums"></param>
        public static void SortColors(int[] nums)
        {
            for (int k = 0; k < nums.Length - 1; k++)
            for (int i = 1; i < nums.Length - k; i++)
                if (nums[i] < nums[i - 1])
                {
                    //Swaping Values
                    nums[i - 1] += nums[i];
                    nums[i] = nums[i - 1] - nums[i];
                    nums[i - 1] -= nums[i];
                }
        }

        /// <summary>
        /// Sort Colors (Better Solution Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        public static void SortColors2(int[] nums)
        {
            int seconds = nums.Length - 1, zeroes = 0;
            for (int i = 0; i <= seconds; i++)
            {
                while (i < seconds && nums[i] == 2)
                {
                    nums[i] += nums[seconds];
                    nums[seconds] = nums[i] - nums[seconds];
                    nums[i] -= nums[seconds--];
                }

                while (i > zeroes && nums[i] == 0)
                {
                    nums[i] += nums[zeroes];
                    nums[zeroes] = nums[i] - nums[zeroes];
                    nums[i] -= nums[zeroes++];
                }
            }
        }
    }
}
