using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// 4Sum II (Not Mine, mine implementation)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <returns></returns>
        public static int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < B.Length; j++)
                {
                    int sum = A[i] + B[j];
                    if (dic.ContainsKey(sum))
                        dic[sum]++;
                    else dic.Add(sum, 1);
                }

            int res = 0;
            for (int i = 0; i < C.Length; i++)
                for (int j = 0; j < D.Length; j++)
                {
                    int sum = -1*(C[i] + D[j]);
                    res += dic.ContainsKey(sum) ? dic[sum] : 0;
                }

            return res;
        }
    }
}
