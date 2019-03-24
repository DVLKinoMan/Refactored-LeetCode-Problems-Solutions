using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            var list = new List<IList<int>>();
            backtrack(list, new List<int>(), nums);
            return list;
        }

        private static void backtrack(List<IList<int>> list, List<int> tempList, int[] nums)
        {
            if (tempList.Count == nums.Length)
                list.Add(new List<int>(tempList));
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (tempList.Contains(nums[i]))
                        continue; 
                    tempList.Add(nums[i]);
                    backtrack(list, tempList, nums);
                    tempList.RemoveAt(tempList.Count - 1);
                }
            }
        }
    }
}
