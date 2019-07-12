using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        //public static int ProfitableSchemes(int G, int P, int[] group, int[] profit)
        //{
        //    int count = 0;
        //    ProfitableSchemesHelper(-1, group, profit, G, P, ref count, 0, 0);
        //    return count;
        //}

        //private static void ProfitableSchemesHelper(int index, int[] group, int[] profit, int G, int P, ref int count, int groupSum, int profitSum)
        //{
        //    for (int i = ++index; i < profit.Length; i++)
        //    {
        //        if (groupSum + group[i] > G)
        //            continue;
        //        if (profitSum + profit[i] >= P)
        //            count++;
        //        ProfitableSchemesHelper(i, group, profit, G, P, ref count, groupSum + group[i], profitSum + profit[i]);
        //    }
        //}

        /// <summary>
        /// Profitable Schemes (Not Mine)
        /// </summary>
        /// <param name="G"></param>
        /// <param name="P"></param>
        /// <param name="group"></param>
        /// <param name="profit"></param>
        /// <returns></returns>
        public static int ProfitableSchemes(int G, int P, int[] group, int[] profit)
        {
            var dp = new int[P + 1, G + 1];
            dp[0, 0] = 1;
            int res = 0, mod = (int)1e9 + 7;
            for (int k = 0; k < group.Length; k++)
            {
                int g = group[k], p = profit[k];
                for (int i = P; i >= 0; i--)
                    for (int j = G - g; j >= 0; j--)
                        dp[Math.Min(i + p, P), j + g] = (dp[Math.Min(i + p, P), j + g] + dp[i, j]) % mod;
            }
            for (int i = 0; i <= G; i++)
                res = (res + dp[P, i]) % mod;
            return res;
        }
    }
}