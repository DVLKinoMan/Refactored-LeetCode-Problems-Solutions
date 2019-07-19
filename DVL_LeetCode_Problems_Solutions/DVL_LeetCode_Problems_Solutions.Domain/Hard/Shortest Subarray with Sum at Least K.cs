using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Shortest Subarray with Sum at Least K (Not Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int ShortestSubarray(int[] A, int K)
        {
            int N = A.Length, res = N + 1;
            int[] B = new int[N + 1];
            for (int i = 0; i < N; i++) B[i + 1] = B[i] + A[i];
            var d = new List<int>();
            for (int i = 0; i < N + 1; i++)
            {
                while (d.Count > 0 && B[i] - B[d.First()] >= K)
                {
                    res = Math.Min(res, i - d.First());
                    d.RemoveAt(0);
                }
                while (d.Count > 0 && B[i] <= B[d.Last()])
                    d.RemoveAt(d.Count-1);
                d.Add(i);
            }
            return res <= N ? res : -1;
        }
    }
}
