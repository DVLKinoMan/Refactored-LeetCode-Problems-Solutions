using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        ///// <summary>
        ///// My Solution (Works but is slow)
        ///// </summary>
        ///// <param name="heights"></param>
        ///// <returns></returns>
        //public static int LargestRectangleArea(int[] heights)
        //{
        //    int max = 0;

        //    for (int i = 0; i < heights.Length - 1; i++)
        //    {
        //        int min = heights[i];
        //        int count = 1;
        //        if (min * count > max)
        //            max = min * count;
        //        for (int j = i + 1; j < heights.Length; j++)
        //        {
        //            min = Math.Min(min, heights[j]);
        //            if (min * (++count) > max)
        //                max = min * count;
        //        }
        //    }

        //    return max;
        //}

        /// <summary>
        /// Largest Rectangle in Histogram (Not mine Solution, but Coded by me)
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public static int LargestRectangleArea(int[] heights)
        {
            int[] lessFromLeftIndexes=new int[heights.Length];
            int[] lessFromRightIndexes=new int[heights.Length];
            lessFromLeftIndexes[0] = -1;
            lessFromRightIndexes[heights.Length - 1] = heights.Length;

            for (int i = 1; i < heights.Length; i++)
            {
                int p = i - 1;
                while (p >= 0 && heights[p] >= heights[i])
                    p = lessFromLeftIndexes[p];

                lessFromLeftIndexes[i] = p;
            }

            for (int i = heights.Length-2; i >= 0; i--)
            {
                int p = i + 1;
                while (p < heights.Length && heights[p] >= heights[i])
                    p = lessFromRightIndexes[p];

                lessFromRightIndexes[i] = p;
            }

            int max = 0;
            for (int i = 0; i < heights.Length; i++)
                max = Math.Max(max, heights[i] * (lessFromRightIndexes[i] - lessFromLeftIndexes[i] - 1));

            return max;
        }
    }
}
