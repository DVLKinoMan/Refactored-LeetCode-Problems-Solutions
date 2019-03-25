using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            var listList = new List<IList<int>>();
            Array.Sort(nums);
            BackTrackingPermuteUnique(listList, new List<int>(), nums);
            return listList;
        }

        private static void BackTrackingPermuteUnique(List<IList<int>> listList, List<int> list, int[] nums)
        {
            if (list.Count == nums.Length)
            {
                listList.Add(new List<int>(list));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (list.Count(num => num == nums[i]) == nums.Count(num => num == nums[i]))
                    continue;
                list.Add(nums[i]);
                BackTrackingPermuteUnique(listList, list, nums);
                list.RemoveAt(list.Count - 1);
                if (list.Count == 0)
                    while (i + 1 < nums.Length && nums[i] == nums[i + 1])
                        i++;
            }
        }
    }
}
