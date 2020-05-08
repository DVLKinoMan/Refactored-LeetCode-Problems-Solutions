namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Check If All 1's Are at Least Length K Places Away (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool KLengthApart(int[] nums, int k)
        {
            int prev = -1;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == 1)
                {
                    if (prev != -1 && i - prev <= k)
                        return false;
                    prev = i;
                }

            return true;
        }
    }
}