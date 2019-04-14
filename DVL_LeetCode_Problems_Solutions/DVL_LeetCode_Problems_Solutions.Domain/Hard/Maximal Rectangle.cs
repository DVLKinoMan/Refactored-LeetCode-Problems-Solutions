using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        //public static int MaximalRectangle(char[][] matrix)
        //{
        //    if (matrix.Length == 0)
        //        return 0;

        //    int m = matrix.Length, n = matrix[0].Length, max = 0;
        //    int[] heights = new int[n];

        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (matrix[i][j] == '0')
        //                heights[j] = 0;
        //            else heights[j] += 1;
        //        }

        //        int potMax = MaximalRectangleHelper(heights);
        //        if (potMax > max)
        //            max = potMax;
        //    }

        //    return max;
        //}

        //private static int MaximalRectangleHelper(int[] heights)
        //{
        //    int count = 0, max=0, min= 0;
        //    for (int j = 0; j < heights.Length; j++)
        //    {
        //        if (heights[j] == 0 || heights[j] == 1)
        //        {
        //            if (count * min > max)
        //                max = count * min;
        //            count = 0;
        //            min = 0;
        //        }
        //        else count++;

        //        if (heights[j] == 1)
        //        {
        //            int c = 0;
        //            while (j < heights.Length && heights[j] == 1)
        //            {
        //                c++;
        //                j++;
        //            }

        //            if (c > max)
        //                max = c;
        //            j--;
        //        }
        //        else if (heights[j] < min || min == 0)
        //            min = heights[j];
        //    }

        //    if (count * min > max)
        //        max = count * min;

        //    return max;
        //}

        /// <summary>
        /// Maximal Rectangle (Not Mine Solution)
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int MaximalRectangle(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return 0;

            int[] height = new int[matrix[0].Length];
            for (int i = 0; i < matrix[0].Length; i++)
                if (matrix[0][i] == '1')
                    height[i] = 1;

            int result = largestInLine(height);
            for (int i = 1; i < matrix.Length; i++)
            {
                resetHeight(matrix, height, i);
                result = Math.Max(result, largestInLine(height));
            }

            return result;
        }

        private static void resetHeight(char[][] matrix, int[] height, int idx)
        {
            for (int i = 0; i < matrix[0].Length; i++)
            {
                if (matrix[idx][i] == '1') height[i] += 1;
                else height[i] = 0;
            }
        }

        private static int largestInLine(int[] height)
        {
            if (height == null || height.Length == 0)
                return 0;
            Stack<int> s = new Stack<int>();
            int maxArea = 0;
            for (int i = 0; i <= height.Length; i++)
            {
                int h = i == height.Length ? 0 : height[i];
                if (s.Count == 0 || h >= height[s.Peek()])
                    s.Push(i);
                else
                {
                    int tp = s.Pop();
                    maxArea = Math.Max(maxArea, height[tp] * (s.Count == 0 ? i : i - 1 - s.Peek()));
                    i--;
                }
            }

            return maxArea;
        }
    }
}
