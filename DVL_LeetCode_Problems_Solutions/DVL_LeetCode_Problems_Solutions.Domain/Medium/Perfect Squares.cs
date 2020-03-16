using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Perfect Squares (Mine and Not Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int NumSquares(int n) {
            // var dict = new Dictionary<int, int>();
            // return Dfs(n);
            //
            // int Dfs(int num)
            // {
            //     if (dict.ContainsKey(num))
            //         return dict[num];
            //     if (num == 1)
            //         return dict[num] = 1;
            //
            //     int min = Int32.MaxValue;
            //     for (int i = num/2; i > 0; i--)
            //     {
            //         int k = num - i * i;
            //         if(k<0)
            //             continue;
            //         if (k == 0)
            //             return 1;
            //         min = Math.Min(min, Dfs(k) + 1);
            //     }
            //
            //     return dict[num] = min;
            // }
            int[] dp = Enumerable.Repeat(int.MaxValue, n+1).ToArray();
            dp[0] = 0;
            for(int i = 1; i <= n; ++i) {
                int min = int.MaxValue;
                int j = 1;
                while(i - j*j >= 0) {
                    min = Math.Min(min, dp[i - j*j] + 1);
                    ++j;
                }
                dp[i] = min;
            }		
            return dp[n];
        }
    }
}