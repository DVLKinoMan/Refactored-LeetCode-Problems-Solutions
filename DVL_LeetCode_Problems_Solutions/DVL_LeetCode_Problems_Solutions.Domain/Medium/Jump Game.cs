namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Jump Game
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool CanJump(int[] nums)
        {
            if (nums.Length <= 1)
                return true;

            int zeroIndex = -1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] == 0 && zeroIndex == -1)
                    zeroIndex = i;
                else if (zeroIndex != -1 && nums[i] > zeroIndex - i)
                    zeroIndex = -1;
            }

            return zeroIndex == -1;
        }
    }
}
