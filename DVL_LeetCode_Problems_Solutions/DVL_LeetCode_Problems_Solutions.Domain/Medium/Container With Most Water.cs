using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Container_With_Most_Water (My Solution. Time - O(n^2))
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            for (int i = 0; i < height.Length; i++)
            for (int j = i + 1; j < height.Length; j++)
            {
                int area = Math.Min(height[i], height[j]) * (j - i);
                if (area > maxArea)
                    maxArea = area;
            }

            return maxArea;
        }

        /// <summary>
        /// Container_With_Most_Water (Better Solution (not mine). time complexity O(n))
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxArea2(int[] height)
        {
            int maxarea = 0, l = 0, r = height.Length - 1;
            while (l < r)
            {
                maxarea = Math.Max(maxarea, Math.Min(height[l], height[r]) * (r - l));
                if (height[l] < height[r])
                    l++;
                else
                    r--;

            }
            return maxarea;
        }
    }
}
