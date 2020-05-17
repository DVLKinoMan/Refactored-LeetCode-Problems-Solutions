using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
      /// <summary>
      /// Consecutive Characters (Mine)
      /// </summary>
      /// <param name="s"></param>
      /// <returns></returns>
      public static int MaxPower(string s) {
         int stIndex = 0, currLen = 1, max = 1;
         for(int i=1; i<s.Length; i++){
            if(s[i]!=s[stIndex])
            {
               stIndex = i;
               max = Math.Max(max, currLen);
               currLen = 1;
            }
            else currLen++;
         }
        
         return Math.Max(max, currLen);
      }
   }
}