using System;
using System.ComponentModel.Design.Serialization;
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

        //public static int SmallestRepunitDivByK(int K)
        //{
        //    int count = 0, des = 1, prevNum = 0;
        //    while (true)
        //    {
        //        int res = SmallestRepunitDivByKHelper(K, des);
        //        if (res == -1)
        //            return res;

        //        count++;

        //        if (prevNum == 10)
        //            prevNum = 0;
        //        prevNum /= 10;
        //        prevNum += res / 10;
        //        if (prevNum == 0)
        //            return count==1 ? count : ++count;

        //        prevNum = count != 1 ? prevNum + 1 : prevNum;

        //        des = SmallestRepunitDivByKHelperWhatToAdd(prevNum);

        //    }
        //}

        //private static int SmallestRepunitDivByKHelperWhatToAdd(int res)
        //{
        //    int lastDigit = res % 10;
        //    for (int i = 0; i < 10; i++)
        //        if ((lastDigit + i) % 10 == 1)
        //            return i;

        //    //It is Impossible
        //    return -1;
        //}

        //private static int SmallestRepunitDivByKHelper(int K, int des)
        //{
        //    for (int i = 1; i < 10; i++)
        //    {
        //        int res = K * i;
        //        if (res % 10 == des)
        //            return res;
        //    }

        //    return -1;
        //}

        /// <summary>
        /// Not mine
        /// </summary>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int SmallestRepunitDivByK(int K)
        {
            if (K % 2 == 0 || K % 5 == 0) return -1;
            int r = 0;
            for (int N = 1; N <= K; ++N)
            {
                r = (r * 10 + 1) % K;
                if (r == 0) return N;
            }

            return -1;
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
