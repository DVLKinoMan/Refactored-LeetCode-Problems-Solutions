using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
      /// <summary>
      /// Minimum Subsequence in Non-Increasing Order (Mine)
      /// </summary>
      /// <param name="nums"></param>
      /// <returns></returns>
      public static IList<int> MinSubsequence(int[] nums)
      {
         int sum = nums.Sum();
         var list = new List<int>();

         int currSum = 0;
         foreach (var num in nums.OrderByDescending(i=>i))
         {
            currSum += num;
            list.Add(num);
            if (currSum > sum / 2)
               break;
         }
         
         return list;
      }
   }
}