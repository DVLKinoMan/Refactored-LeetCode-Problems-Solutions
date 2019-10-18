using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximize Distance to Closest Person (Mine)
        /// </summary>
        /// <param name="seats"></param>
        /// <returns></returns>
        public static int MaxDistToClosest(int[] seats)
        {
            int[] rightClosest = new int[seats.Length];
            int[] leftClosest = new int[seats.Length];

            int last = int.MaxValue;
            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 1)
                    last = i;
                leftClosest[i] = last == int.MaxValue ? last : i - last;
            }

            last = int.MaxValue;
            for (int i = seats.Length - 1; i >= 0; i--)
            {
                if (seats[i] == 1)
                    last = i;
                rightClosest[i] = last == int.MaxValue ? last : last - i;
            }

            int max = 0;
            for (int i = 0; i < seats.Length; i++)
                max = Math.Max(max, Math.Min(rightClosest[i], leftClosest[i]));

            return max == int.MaxValue ? 0 : max;
        }
    }
}
