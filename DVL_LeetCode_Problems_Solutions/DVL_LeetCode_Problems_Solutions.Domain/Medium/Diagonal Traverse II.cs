using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Diagonal Traverse II (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] FindDiagonalOrder(IList<IList<int>> nums)
        {
            var res = new List<int>();
            var q = new Queue<int[]>();
            q.Enqueue(new int[] {0, 0});

            while (q.Count > 0)
            {
                var count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    var curr = q.Dequeue();
                    res.Add(nums[curr[0]][curr[1]]);
                    if (curr[1] == 0 && curr[0] < nums.Count() - 1)
                        q.Enqueue(new int[] {curr[0] + 1, 0});

                    if (nums[curr[0]].Count() - 1 > curr[1])
                        q.Enqueue(new int[] {curr[0], curr[1] + 1});
                }
            }

            return res.ToArray();
        }
    }
}