using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        ///// <summary>
        ///// Time limit Exceeding(Mine)
        ///// </summary>
        ///// <param name="piles"></param>
        ///// <param name="lastIndex"></param>
        ///// <param name="alexSum"></param>
        ///// <param name="M"></param>
        ///// <param name="alexTurn"></param>
        ///// <returns></returns>
        //public static int StoneGameII(int[] piles, int lastIndex = -1, int alexSum = 0, int M = 1, bool alexTurn = true)
        //{
        //    if (lastIndex == piles.Length - 1)
        //        return alexSum;

        //    int max = 0, sum = 0, min = int.MaxValue;
        //    for (int x = 1; x <= 2 * M && lastIndex + x < piles.Length; x++)
        //    {
        //        if (alexTurn)
        //        {
        //            sum += piles[lastIndex + x];
        //            max = Math.Max(max, StoneGameII(piles, lastIndex + x, alexSum + sum, Math.Max(M, x), !alexTurn));
        //        }
        //        else min = Math.Min(min, StoneGameII(piles, lastIndex + x, alexSum, Math.Max(M, x), !alexTurn));
        //    }

        //    return alexTurn ? max : min;
        //}

        /// <summary>
        /// Stone Game II (Not Mine)
        /// </summary>
        /// <param name="piles"></param>
        /// <returns></returns>
        public static int StoneGameII(int[] piles)
        {
            int n = piles.Length;
            int[] sums =  new int[n];
            int[,] hash = new int[n, n];

            if (piles == null || n == 0)
                return 0;

            sums[n - 1] = piles[n - 1];
            for (int i = n - 2; i >= 0; i--)
                sums[i] = sums[i + 1] + piles[i]; //the sum from piles[i] to the end

            return StoneGameIIHelper(piles, 0, 1, sums, hash);
        }

        private static int StoneGameIIHelper(int[] piles, int i, int M, int[] sums, int[,] hash)
        {
            if (i == piles.Length)
                return 0;

            if (2 * M >= piles.Length - i)
                return sums[i];

            if (hash[i, M] != 0)
                return hash[i, M];

            int min = int.MaxValue;//the min value the next player can get
            for (int x = 1; x <= 2 * M; x++)
                min = Math.Min(min, StoneGameIIHelper(piles, i + x, Math.Max(M, x), sums, hash));

            hash[i, M] = sums[i] - min;  //max stones = all the left stones - the min stones next player can get
            return hash[i, M];
        }
    }
}
