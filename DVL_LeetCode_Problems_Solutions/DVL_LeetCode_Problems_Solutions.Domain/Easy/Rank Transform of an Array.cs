using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
       /// <summary>
       /// Rank Transform of an Array (Mine)
       /// </summary>
       /// <param name="arr"></param>
       /// <returns></returns>
      public static int[] ArrayRankTransform(int[] arr) {
        int[] result = new int[arr.Length];
        
        if (arr.Length == 0)
            return result;
        
        var dict = new Dictionary<int,int>();
        foreach (var num in arr)
            if(!dict.ContainsKey(num))
                dict.Add(num, 0);

        int count = 1;
        foreach (var num in dict.OrderBy(d=>d.Key).Select(d=>d.Key))
            dict[num] += count++;

        for (var i = 0; i < arr.Length; i++)
            result[i] = dict[arr[i]];

        return result;
      }
   }
}