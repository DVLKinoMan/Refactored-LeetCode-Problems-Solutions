using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Split Array into Consecutive Subsequences (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool IsPossible(int[] nums)
        {
            //int pre = int.MinValue;
            //int p1 = 0;
            //int p2 = 0;
            //int p3 = 0;

            //int cur = 0;
            //int cnt = 0;
            //int c1 = 0;
            //int c2 = 0;
            //int c3 = 0;

            //for (int i = 0; i < nums.Length; pre = cur, p1 = c1, p2 = c2, p3 = c3)
            //{
            //    cur = nums[i];
            //    cnt = 0;
            //    while(i < nums.Length && cur == nums[i])
            //    {
            //        cnt++;
            //        i++;
            //    }

            //    if (cur != pre + 1)
            //    {
            //        if (p1 != 0 || p2 != 0)
            //        {
            //            return false;
            //        }

            //        c1 = cnt;
            //        c2 = 0;
            //        c3 = 0;
            //    }
            //    else
            //    {
            //        if (cnt < p1 + p2)
            //            return false;

            //        c1 = Math.Max(0, cnt - (p1 + p2 + p3));
            //        c2 = p1;
            //        c3 = p2 + Math.Min(p3, cnt - (p1 + p2));
            //    }
            //}

            //return (p1 == 0 && p2 == 0);
            var left = new Dictionary<int, int>();
            foreach (var num in nums)
                left[num] = left.ContainsKey(num) ? left[num] + 1 : 1;
            var end = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!left.ContainsKey(num) || left[num] == 0)
                    continue;
                left[num] -= 1;
                if (end.ContainsKey(num - 1) && end[num - 1] > 0)
                {
                    end[num - 1] -= 1;
                    end[num] = end.ContainsKey(num) ? end[num] + 1 : 1;
                }
                else if (left.ContainsKey(num + 1) && left[num + 1] != 0 && left.ContainsKey(num + 2) &&
                         left[num + 2] != 0)
                {
                    left[num + 1] -= 1;
                    left[num + 2] -= 1;
                    end[num + 2] = end.ContainsKey(num + 2) ? end[num + 2] + 1 : 1;
                }
                else return false;
            }

            return true;
        }
    }
}
