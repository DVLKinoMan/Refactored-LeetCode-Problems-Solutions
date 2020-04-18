namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
       /// <summary>
       /// Find Pivot Index (Mine)
       /// </summary>
       /// <param name="nums"></param>
       /// <returns></returns>
      public static int PivotIndex(int[] nums)
      {
          int[] leftSums = new int[nums.Length];
          int[] rightSums = new int[nums.Length];
          for (int i = 1; i < nums.Length; i++)
          {
              leftSums[i] = nums[i - 1] + leftSums[i - 1];
              rightSums[nums.Length - i - 1] = nums[nums.Length - i] + rightSums[nums.Length - i];
          }

          for (int i = 0; i < nums.Length; i++)
              if (leftSums[i] == rightSums[i])
                  return i;

          return -1;
      }
   }
}