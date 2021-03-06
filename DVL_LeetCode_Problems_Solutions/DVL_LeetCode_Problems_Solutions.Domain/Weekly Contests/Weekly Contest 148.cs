﻿using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Decrease Elements To Make Array Zigzag (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MovesToMakeZigzag(int[] nums)
        {
            int count1 = 0, count2 = 0;
            int[] arr = nums.ToArray();
            for (int i = 0; i < arr.Length; i += 2)
            {
                if (i > 0 && arr[i - 1] >= arr[i])
                    count1 += (arr[i - 1] - arr[i] + 1);

                if (i < nums.Length - 1 && nums[i] <= nums[i + 1])
                {
                    count1 += (arr[i + 1] - arr[i] + 1);
                    arr[i + 1] = arr[i] - 1;
                }
            }

            arr = nums.ToArray();
            for (int i = 1; i < arr.Length; i += 2)
            {
                if (i > 0 && arr[i - 1] >= arr[i])
                    count2 += (arr[i - 1] - arr[i] + 1);
                if (i < arr.Length - 1 && arr[i] <= arr[i + 1])
                {
                    count2 += (arr[i + 1] - arr[i] + 1);
                    arr[i + 1] = arr[i] - 1;
                }
            }

            return Math.Min(count1, count2);
        }

        /// <summary>
        /// Longest Chunked Palindrome Decomposition (Mine - did it after contest, but i had little mistake in contest and did not work becuase of that)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int LongestDecomposition(string text)
        {
            int count = 0, index = 0, len = 1, divlen = text.Length / 2;
            bool lastElement = false;
            while (index + len - 1 < divlen)
            {
                if (text.Substring(index, len) == text.Substring(text.Length - index - len, len))
                {
                    count += 2;
                    index += len;
                    len = 1;
                    lastElement = true;
                }
                else
                {
                    len++;
                    lastElement = false;
                }
            }

            return lastElement && text.Length % 2 == 0 ? count : count + 1;
        }
    }
}
