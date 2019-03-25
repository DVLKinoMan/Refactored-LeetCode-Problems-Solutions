using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Permutations II (My Version, Working)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            var listList = new List<IList<int>>();
            Array.Sort(nums);
            BackTrackingPermuteUnique(listList, new List<int>(), nums, new List<int>());
            return listList;
        }

        private static void BackTrackingPermuteUnique(List<IList<int>> listList, List<int> list, int[] nums,
            List<int> skipIndexes)
        {
            if (list.Count == nums.Length)
            {
                listList.Add(new List<int>(list));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
                if (!skipIndexes.Contains(i))
                {
                    //if (list.Count(num => num == nums[i]) == nums.Count(num => num == nums[i]))
                    //    continue;
                    list.Add(nums[i]);
                    skipIndexes.Add(i);
                    BackTrackingPermuteUnique(listList, list, nums, skipIndexes);
                    list.RemoveAt(list.Count - 1);
                    skipIndexes.RemoveAt(skipIndexes.Count - 1);
                    //if (list.Count == 0)
                        while (i + 1 < nums.Length && nums[i] == nums[i + 1])
                            i++;
                }
        }

        /// <summary>
        /// Permutations II (Less Space Used, but the Same speed)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> PermuteUniqueBetter(int[] nums)
        {
            var listList = new List<IList<int>>();
            Array.Sort(nums);
            BackTrackingPermuteUniqueBetter(listList, new List<int>(), nums, new bool[nums.Length]);
            return listList;
        }

        private static void BackTrackingPermuteUniqueBetter(List<IList<int>> listList, List<int> list, int[] nums, bool[] skipIndexes)
        {
            if (list.Count == nums.Length)
            {
                listList.Add(new List<int>(list));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (skipIndexes[i])
                    continue;
                list.Add(nums[i]);
                skipIndexes[i] = true;
                BackTrackingPermuteUniqueBetter(listList, list, nums, skipIndexes);
                list.RemoveAt(list.Count - 1);
                skipIndexes[i] = false;
                while (i + 1 < nums.Length && nums[i] == nums[i + 1])
                    i++;
            }
        }
    }
}
