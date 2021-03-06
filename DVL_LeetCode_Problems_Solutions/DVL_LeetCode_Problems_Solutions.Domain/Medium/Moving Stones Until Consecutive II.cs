﻿using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Moving Stones Until Consecutive II (Not Mine)
        /// </summary>
        /// <param name="stones"></param>
        /// <returns></returns>
        public static int[] NumMovesStonesII(int[] stones)
        {
            Array.Sort(stones);
            int i = 0, n = stones.Length, low = n;
            int high = Math.Max(stones[n - 1] - n + 2 - stones[1], stones[n - 2] - stones[0] - n + 2);
            for (int j = 0; j < n; ++j)
            {
                while (stones[j] - stones[i] >= n) ++i;
                if (j - i + 1 == n - 1 && stones[j] - stones[i] == n - 2)
                    low = Math.Min(low, 2);
                else
                    low = Math.Min(low, n - (j - i + 1));
            }
            return new int[] { low, high };
        }
    }
}
