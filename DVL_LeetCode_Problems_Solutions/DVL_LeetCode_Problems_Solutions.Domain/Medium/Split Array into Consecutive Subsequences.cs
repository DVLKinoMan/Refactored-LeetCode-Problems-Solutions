using System;

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
            int pre = int.MinValue;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            int cur = 0;
            int cnt = 0;
            int c1 = 0;
            int c2 = 0;
            int c3 = 0;

            for (int i = 0; i < nums.Length; pre = cur, p1 = c1, p2 = c2, p3 = c3)
            {
                cur = nums[i];
                cnt = 0;
                while(i < nums.Length && cur == nums[i])
                {
                    cnt++;
                    i++;
                }

                if (cur != pre + 1)
                {
                    if (p1 != 0 || p2 != 0)
                    {
                        return false;
                    }

                    c1 = cnt;
                    c2 = 0;
                    c3 = 0;
                }
                else
                {
                    if (cnt < p1 + p2)
                        return false;

                    c1 = Math.Max(0, cnt - (p1 + p2 + p3));
                    c2 = p1;
                    c3 = p2 + Math.Min(p3, cnt - (p1 + p2));
                }
            }

            return (p1 == 0 && p2 == 0);
        }
    }
}
