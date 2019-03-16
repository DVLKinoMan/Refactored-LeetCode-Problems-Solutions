﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// 3Sum (My Version. Timeout)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            var dic = new Dictionary<int, List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]].Add(i);
                else dic.Add(nums[i], new List<int> {i});
            }

            for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
            {
                int minus = (nums[i] + nums[j]) * -1;
                if (dic.ContainsKey(minus) && dic[minus].Any(n => n != i && n != j))
                {
                    var l1 = new List<int> {nums[i], nums[j], minus};
                    if (!list.Any(l => l.Contains(minus) && l.Except(l1).Count() == 0))
                        list.Add(l1);
                }
            }

            return list;
        }

        /// <summary>
        /// 3Sum
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> ThreeSumBetter(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                int begin = i + 1, end = nums.Length - 1;
                while (begin < end)
                {
                    int sum = nums[i] + nums[begin] + nums[end];
                    if (sum == 0)
                    {
                        list.Add(new List<int> {nums[i], nums[begin], nums[end]});
                        begin++;
                        end--;
                        while (begin < end && nums[begin] == nums[begin - 1])
                            begin++;
                        while (begin < end && nums[end] == nums[end + 1])
                            end--;
                    }
                    else if (sum < 0)
                    {
                        begin++;
                        while (begin < end && nums[begin] == nums[begin - 1])
                            begin++;
                    }
                    else
                    {
                        end--;
                        while (begin < end && nums[end] == nums[end + 1])
                            end--;
                    }
                }

                while (i + 1 < nums.Length && nums[i] == nums[i + 1])
                    i++;
            }

            return list;
        }
    }
}
