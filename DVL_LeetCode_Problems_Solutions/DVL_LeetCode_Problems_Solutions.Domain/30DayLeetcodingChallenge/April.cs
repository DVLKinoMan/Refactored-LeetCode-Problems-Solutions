using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Single Number (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNumber(int[] nums)
        {
            int k = 0;
            foreach (var num in nums)
                k ^= num;
            return k;
        }

        /// <summary>
        /// Happy Number (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsHappy(int n)
        {
            var set = new HashSet<int>();
            while (set.Add(n) && n != 1)
                n = Sum(n);

            return n == 1;

            int Sum(int k)
            {
                int res = 0;
                while (k != 0)
                {
                    res += (int) Math.Pow(k % 10, 2);
                    k /= 10;
                }

                return res;
            }
        }

        /// <summary>
        /// Maximum Subarray (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxSubArray(int[] nums)
        {
            int currSum = nums[0], maxSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (currSum + nums[i] < nums[i])
                    currSum = nums[i];
                else currSum += nums[i];
                maxSum = Math.Max(maxSum, currSum);
            }

            return maxSum;
        }
        
        // public static void MoveZeroes(int[] nums) {
        //     int lastZeroIndex = nums.Length;
        //     for (int i = 0; i < lastZeroIndex; i++)
        //         if (nums[i] == 0)
        //         {
        //             int i2 = i;
        //             while (i2 != lastZeroIndex - 1)
        //             {
        //                 //swap
        //                 nums[i2 + 1] += nums[i2];
        //                 nums[i2] = nums[i2 + 1] - nums[i2];
        //                 nums[i2 + 1] -= nums[i2];
        //                 i2++;
        //             }
        //
        //             lastZeroIndex--;
        //             i--;
        //         }
        // }
    }
}