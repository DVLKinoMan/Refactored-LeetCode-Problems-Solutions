using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
      /// <summary>
      /// Check If a String Can Break Another String (Mine)
      /// </summary>
      /// <param name="s1"></param>
      /// <param name="s2"></param>
      /// <returns></returns>
      public static bool CheckIfCanBreak(string s1, string s2)
      {
         var list1 = s1.OrderBy(ch => ch).ToList();
         var list2 = s2.OrderBy(ch => ch).ToList();
         bool? s1IsBigger = null;
         for (int i = 0; i < list1.Count; i++)
         {
            if (s1IsBigger == null)
               s1IsBigger = list1[i] == list2[i] ? (bool?)null : list1[i] > list2[i];
            else if ((s1IsBigger.Value && list1[i] < list2[i]) || (!s1IsBigger.Value && list1[i] > list2[i]))
               return false;
         }

         return true;
      }
   }
}