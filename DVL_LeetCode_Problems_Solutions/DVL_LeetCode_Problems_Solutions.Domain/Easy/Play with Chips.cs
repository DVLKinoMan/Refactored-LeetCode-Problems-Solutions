using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Play with Chips (Not Mine)
        /// </summary>
        /// <param name="chips"></param>
        /// <returns></returns>
        public static int MinCostToMoveChips(int[] chips)
        {
            int odd = 0, even = 0;
            foreach (int a in chips)
                if (a % 2 == 0)
                    ++even;
                else
                    ++odd;

            return Math.Min(odd, even);
        }
    }
}
