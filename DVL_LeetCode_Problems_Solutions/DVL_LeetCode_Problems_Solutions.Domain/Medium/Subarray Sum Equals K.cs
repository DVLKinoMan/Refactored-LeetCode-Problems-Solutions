using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Subarray Sum Equals K (Mine - time is O(n^2)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SubarraySum(int[] nums, int k)
        {
            if (nums.Length == 0)
                return 0;

            int count = 0, fsum = 0;
            for (int len = 1; len <= nums.Length; len++)
                count +=SubarryaSumHelper(nums, k, len, ref fsum);

            return count;
        }

        private static int SubarryaSumHelper(int[] nums, int k, int len, ref int fsum)
        {
            fsum += nums[len - 1];
            int sum = fsum;
            int count = sum == k ? 1 : 0;
            for (int i = 1; i + len <= nums.Length; i++)
            {
                sum -= nums[i - 1];
                sum += nums[i + len - 1];
                if (sum == k)
                    count++;
            }

            return count;
        }

        /// <summary>
        /// Subarray Sum Equals K
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SubarraySum2(int[] nums, int k)
        {
            int count = 0, sum = 0;
            var dic = new Dictionary<int,int>();
            dic.Add(0,1);

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (dic.ContainsKey(sum - k))
                    count += dic[sum - k];

                if (dic.ContainsKey(sum))
                    dic[sum] += 1;
                else dic.Add(sum,1);
            }

            return count;
        }
    }
}
