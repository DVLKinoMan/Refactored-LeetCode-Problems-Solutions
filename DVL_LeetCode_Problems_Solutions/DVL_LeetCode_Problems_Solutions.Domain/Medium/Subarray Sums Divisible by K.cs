using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Subarray Sums Divisible by K (Not Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int SubarraysDivByK(int[] A, int K)
        {
            int count = 0,sum = 0;
            var dic = new Dictionary<int,int>();
            dic.Add(0,1);
            foreach (var a in A)
            {
                sum = (sum + a) % K;
                if (sum < 0)
                    sum += K;
                if (dic.ContainsKey(sum))
                {
                    count += dic[sum];
                    dic[sum]++;
                }
                else dic.Add(sum, 1);
            }

            return count;
        }
    }
}
