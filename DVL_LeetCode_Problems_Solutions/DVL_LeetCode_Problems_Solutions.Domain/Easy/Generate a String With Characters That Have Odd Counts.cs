using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
       /// <summary>
       /// Generate a String With Characters That Have Odd Counts (Mine)
       /// </summary>
       /// <param name="n"></param>
       /// <returns></returns>
      public static string GenerateTheString(int n) {
          if (n % 2 == 0)
              return string.Join("", Enumerable.Repeat('a', n - 1)) + 'b';

          return string.Join("", Enumerable.Repeat('a', n));
      }
   }
}