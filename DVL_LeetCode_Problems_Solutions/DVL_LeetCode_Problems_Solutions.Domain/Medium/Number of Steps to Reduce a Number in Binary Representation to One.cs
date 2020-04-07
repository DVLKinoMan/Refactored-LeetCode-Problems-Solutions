using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
      /// <summary>
      /// Number of Steps to Reduce a Number in Binary Representation to One (Mine)
      /// </summary>
      /// <param name="s"></param>
      /// <returns></returns>
      public static int NumSteps(string s)
      {
         var builder = new StringBuilder(s);
         int steps = 0;
         while (builder.Length != 1)
         {
            if (builder[builder.Length - 1] == '1')
            {
               int index = builder.Length - 1;
               while (index >= 0 && builder[index] == '1')
                  builder[index--] = '0';
               if (index < 0)
                  builder.Insert(0, '1');
               else builder[index] = '1';
            }
            else builder.Remove(builder.Length - 1, 1);

            steps++;
         }

         return steps;
      }
   }
}