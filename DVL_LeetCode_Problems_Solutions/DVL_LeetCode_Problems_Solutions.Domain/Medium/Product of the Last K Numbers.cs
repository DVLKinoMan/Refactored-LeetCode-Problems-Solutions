using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
      /// <summary>
      /// Product of the Last K Numbers (Not Mine)
      /// </summary>
      public class ProductOfNumbers
      {
         private List<int> list;
         private int n;

         public ProductOfNumbers()
         {
            Add(0);
         }

         public void Add(int a)
         {
            if (a > 0)
            {
               list.Add(list[n - 1] * a);
               n++;
            }
            else
            {
               list = new List<int> {1};
               n = 1;
            }
         }

         public int GetProduct(int k) {
            return k < n ? 
               list[n - 1] / list[n - k - 1]  : 0;
         }
      }
   }
}