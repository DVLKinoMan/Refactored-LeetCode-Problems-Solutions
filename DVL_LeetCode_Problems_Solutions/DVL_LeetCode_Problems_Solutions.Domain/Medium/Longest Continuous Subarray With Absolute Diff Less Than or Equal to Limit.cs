using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
      /// <summary>
      /// Longest Continuous Subarray With Absolute Diff Less Than or Equal to Limit (mine)
      /// </summary>
      /// <param name="nums"></param>
      /// <param name="limit"></param>
      /// <returns></returns>
      public static int LongestSubarray(int[] nums, int limit)
      {
         var sortedItems = new List<int>() {nums[0]};
         int min = nums[0], max = nums[0], maxLen = 1, currLen = 1, firstIndex = 0;

         for (int i = 1; i < nums.Length; i++)
         {
            min = Math.Min(min, nums[i]);
            max = Math.Max(max, nums[i]);
            Add(nums[i]);
            currLen++;
            while (max - min > limit)
            {
               //Removing nums[firstIndex] from sorted list
               int ind = sortedItems.BinarySearch(nums[firstIndex]);
               sortedItems.RemoveAt(ind);
               min = sortedItems[0];
               max = sortedItems[sortedItems.Count - 1];
               firstIndex++;
               currLen--;
            }

            maxLen = Math.Max(currLen, maxLen);
         }
         
         return maxLen;
         
         //Add with Binary Search
         void Add(int num)
         {
            int st = 0, end = sortedItems.Count - 1;
            while (st < end)
            {
               int mid = (st + end) / 2;
               if (sortedItems[mid] > num)
                  end = mid - 1;
               else st = mid + 1;
            }

            if (sortedItems[st] > num)
               sortedItems.Insert(st, num);
            else sortedItems.Insert(st + 1, num);
         }
      }
   }
}