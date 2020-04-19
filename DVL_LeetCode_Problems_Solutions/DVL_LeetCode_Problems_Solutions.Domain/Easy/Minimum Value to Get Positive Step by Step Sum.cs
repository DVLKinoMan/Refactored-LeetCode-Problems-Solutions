using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
      /// <summary>
      /// Minimum Value to Get Positive Step by Step Sum (Mine)
      /// </summary>
      /// <param name="nums"></param>
      /// <returns></returns>
      public static int MinStartValue(int[] nums)
      {
         int sum = 0, minSum = int.MaxValue;
         foreach (var num in nums)
         {
            sum += num;
            minSum = Math.Min(minSum, sum);
         }

         return minSum > 0 ? 1 : 1 - minSum;
      }
   }
}