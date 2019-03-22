using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        ///// <summary>
        ///// My Solution(Do not Works
        ///// </summary>
        ///// <param name="height"></param>
        ///// <returns></returns>
        //public static int Trap(int[] height)
        //{
        //    if (height.Length == 0)
        //        return 0;

        //    int curr = height[0], currIndex = 0, result = 0, units = 0;
        //    for (int i = 1; i < height.Length; i++)
        //        if (height[i] > curr)
        //            units +=height[i] - curr;
        //        else
        //        {
        //            result += units;
        //            units = 0;
        //            i = currIndex;
        //            currIndex ++;
        //            if (currIndex < height.Length)
        //                curr = height[currIndex];
        //        }

        //    currIndex++;
        //    if (currIndex < height.Length)
        //    {
        //        for (int i = currIndex; i < height.Length; i++)
        //        {

        //        }
        //    }

        //    return result;
        //}

        /// <summary>
        /// Trapping Rain Water (Not Mine - O(n) time, O(n) space)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int Trap(int[] height)
        {
            if (height.Length == 0)
                return 0;

            var leftMax = new List<int>() { height[0] };
            var rightMax = new List<int>() { height[height.Length - 1] };
            for (int i = 1; i < height.Length; i++)
            {
                leftMax.Add(Math.Max(leftMax[i - 1], height[i]));
                rightMax.Add(Math.Max(rightMax[i - 1], height[height.Length - i - 1]));
            }

            int result = 0;
            for (int i = 1; i < height.Length; i++)
                result += Math.Min(leftMax[i], rightMax[height.Length - i - 1]) - height[i];

            return result;
        }
    }
}
