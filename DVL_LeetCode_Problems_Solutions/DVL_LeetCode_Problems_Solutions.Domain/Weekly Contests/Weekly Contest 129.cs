using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static bool CanThreePartsEqualSum(int[] A)
        {
            int sum = A.Sum();
            if (sum % 3 != 0)
                return false;
            int onePartSum = sum / 3;
            int sum2 = 0;
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum2 += A[i];
                if (sum2 == onePartSum)
                {
                    sum2 = 0;
                    count++;
                }
            }

            return count == 3;
        }

        public static int SmallestRepunitDivByK(int K)
        {
            int i = 1, count = 1;
            while (true)
            {
                if (i % K == 0)
                    return count;
                count++;
                if (!int.TryParse(i.ToString() + '1', out i))
                    return -1;
            }
        }

        /// <summary>
        /// Best Sightseeing Pair (Not mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MaxScoreSightseeingPair(int[] A)
        {
            int res = 0, curr = 0;

            foreach (var a in A)
            {
                res = Math.Max(res, curr + a);
                curr = Math.Max(curr, a) - 1;
            }

            return res;
        }
    }
}
