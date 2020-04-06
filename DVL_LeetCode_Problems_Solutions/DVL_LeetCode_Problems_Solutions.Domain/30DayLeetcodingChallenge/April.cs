using System;
using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        /// Best Time to Buy and Sell Stock II (Not Mine)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit2(int[] prices)
        {
            int total = 0;
            for (int i = 0; i < prices.Length - 1; i++)
                if (prices[i + 1] > prices[i])
                    total += prices[i + 1] - prices[i];

            return total;
        }
        
        // public static IList<IList<string>> GroupAnagrams(string[] strs) {
        //     var dic=new Dictionary<string, List<string>>();
        //     foreach (var str in strs)
        //     {
        //         var strSorted = String.Concat(str.OrderBy(s => s));
        //         if (dic.ContainsKey(strSorted))
        //             dic[strSorted].Add(str);
        //         else dic.Add(strSorted, new List<string> { str });
        //     }
        //
        //     var result = new List<IList<string>>();
        //     foreach (var d in dic)
        //         result.Add(d.Value);
        //
        //     return result;
        // }
    }
}