namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Rotate Array (Not Working)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            for(int i=0; i<k; i++)
            {
                int remember = nums[i];
                int len = nums.Length / (k - 1) + (nums.Length % (k - 1) > 0 ? 1 : 0);
                for (int j = 1; j < len; j++)
                {
                    //Swap
                    int index = (i + j * k) % nums.Length;
                    nums[index] += remember;
                    remember = nums[index] - remember;
                    nums[index] -= remember;
                }
            }
        }
    }
}
