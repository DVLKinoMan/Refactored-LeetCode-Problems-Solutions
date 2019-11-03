namespace DVL_LeetCode_Problems_Solutions.Domain.Weekly_Contests
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Count Number of Nice Subarrays (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int NumberOfSubarrays(int[] nums, int k)
        {
            int start = 0, count = 0, res = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] % 2 == 1)
                {
                    count++;
                    if (count == k)
                    {
                        int num = 0;
                        while (true)
                        {
                            num++;
                            if (nums[start] % 2 == 1)
                                break;
                            start++;
                        }

                        int prevNum = num;
                        i++;
                        while (i < nums.Length && nums[i] % 2 == 0)
                        {
                            i++;
                            num += prevNum;
                        }
                        i--;

                        res += num;
                        count = k - 1;
                        start++;
                    }
                }

            return res;
        }
    }
}
